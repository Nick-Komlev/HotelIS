using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using Wrapper;

namespace TestKernelApp
{
    class DBConnector
    {
        //private static string connectionString = "Server=SQLSRV;Database=TestDB;User Id=client;Password=Qwert123!";
        private static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=HotelTest;Integrated Security=True";

        public DBConnector()
        {
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    SqlCommand command = new SqlCommand("SELECT * FROM test_table", connection);
            //    SqlDataReader reader = command.ExecuteReader();

            //    if (reader.HasRows) // если есть данные
            //    {
            //        while (reader.Read()) // построчно считываем данные
            //        {
            //            Console.WriteLine(reader.GetValue(0).ToString() + ", " + reader.GetValue(1));
            //        }
            //    }
            //    reader.Close();
            //}
        }

        public string CreateObject(USerializableList paramls)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string name = paramls.Items[0].ToString();
                string prefix = paramls.Items[1].ToString();
                string descr = paramls.Items[2].ToString();
                List<UAttribute> attrs = new List<UAttribute>();
                List<State> states = new List<State>();

                int stateFlag = 0;

                for (int i = 3; i < paramls.Items.Count; i++)
                {
                    if (paramls.Items[i].ToString() == "статусы")
                    {
                        stateFlag = i;
                        break;
                    }
                        
                    attrs.Add(paramls.Items[i] as UAttribute);
                }

                for (int i = stateFlag + 1; i < paramls.Items.Count; i++)
                {
                    states.Add(paramls.Items[i] as State);
                }

                SqlCommand command = new SqlCommand(string.Format("INSERT INTO object (name, table_prefix, description) VALUES ('{0}', '{1}', '{2}');", new object[] { name, prefix, descr })
                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                int id = 0;
                command = new SqlCommand(string.Format("SELECT id FROM object WHERE name = '{0}';", name)
                                            , connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        id = (int)reader.GetValue(0);
                    }
                }
                reader.Close();
                command.Dispose();


                command = new SqlCommand(string.Format("CREATE TABLE {0} (id int IDENTITY (1, 1) NOT NULL, CONSTRAINT PK_{0}_id PRIMARY KEY CLUSTERED (id));", prefix)
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand(string.Format("CREATE TABLE attribute_{0} (id int IDENTITY (1, 1) NOT NULL, name varchar (50) NOT NULL, type varchar (50) NOT NULL, CONSTRAINT PK_attribute_{0}_id PRIMARY KEY CLUSTERED (id));", prefix)
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand(string.Format("CREATE TABLE decimal_value_{0} (id int IDENTITY (1, 1) NOT NULL, dec_val decimal(18, 0) NOT NULL, str_val varchar (50) NOT NULL, attr_val int NOT NULL, CONSTRAINT PK_decimal_value_{0}_id PRIMARY KEY CLUSTERED (id));", prefix)
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand(string.Format("CREATE TABLE string_value_{0} (id int IDENTITY (1, 1) NOT NULL, str_val varchar (300) NOT NULL, attr_val int NOT NULL, CONSTRAINT PK_string_value_{0}_id PRIMARY KEY CLUSTERED (id));", prefix)
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand(string.Format("CREATE TABLE boolean_value_{0} (id int IDENTITY (1, 1) NOT NULL, bool_val bit NOT NULL, str_val varchar (50) NOT NULL, attr_val int NOT NULL, CONSTRAINT PK_boolean_value_{0}_id PRIMARY KEY CLUSTERED (id));", prefix)
                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand(string.Format("CREATE TABLE date_value_{0} (id int IDENTITY (1, 1) NOT NULL, date_val date NOT NULL, str_val varchar (50) NOT NULL, attr_val int NOT NULL, CONSTRAINT PK_date_value_{0}_id PRIMARY KEY CLUSTERED (id));", prefix)
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand(string.Format("CREATE TABLE attribute_value_{0} (id int IDENTITY (1, 1) NOT NULL, {0}_id int, attr_id int, CONSTRAINT PK_attribute_value_{0}_id PRIMARY KEY CLUSTERED (id));", prefix)
                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand(string.Format("ALTER TABLE attribute_value_{0} WITH CHECK ADD CONSTRAINT [FK_attribute_value_{0}_{0}] FOREIGN KEY ({0}_id) REFERENCES {0} (id);", prefix)
                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand(string.Format("ALTER TABLE attribute_value_{0} WITH CHECK ADD CONSTRAINT [FK_attribute_value_{0}_attribute_{0}] FOREIGN KEY (attr_id) REFERENCES attribute_value_{0} (id);", prefix)
                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand(string.Format("ALTER TABLE decimal_value_{0} WITH CHECK ADD CONSTRAINT [FK_decimal_value_{0}attribute_value_{0}] FOREIGN KEY (attr_val) REFERENCES attribute_value_{0} (id);", prefix)
                            , connection);
                command.Dispose();
                command.ExecuteNonQuery();

                command = new SqlCommand(string.Format("ALTER TABLE string_value_{0} WITH CHECK ADD CONSTRAINT [FK_string_value_{0}attribute_value_{0}] FOREIGN KEY (attr_val) REFERENCES attribute_value_{0} (id);", prefix)
                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand(string.Format("ALTER TABLE boolean_value_{0} WITH CHECK ADD CONSTRAINT [FK_boolean_value_{0}attribute_value_{0}] FOREIGN KEY (attr_val) REFERENCES attribute_value_{0} (id);", prefix)
                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand(string.Format("ALTER TABLE date_value_{0} WITH CHECK ADD CONSTRAINT [FK_date_value_{0}attribute_value_{0}] FOREIGN KEY (attr_val) REFERENCES attribute_value_{0} (id);", prefix)
                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                foreach (UAttribute attr in attrs)
                {
                    command = new SqlCommand(string.Format("INSERT INTO attribute_{0} (name, type) VALUES ('{1}', '{2}');", prefix, attr.Name, attr.Type)
                            , connection);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }

                foreach (State state in states)
                {
                    command = new SqlCommand(string.Format("INSERT INTO state_enabled (obj_id, state_id) VALUES ('{0}', '{1}');", id, state.Id)
                            , connection);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }

            return "Object created";
        }

        public string CreateState(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(string.Format("INSERT INTO state (name) VALUES ('{0}');", name)
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();
            }
            return "State created";
        }

        public List<State> LoadState()
        {
            List<State> states = new List<State>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM state;"
                                            , connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        states.Add(new State((int)reader.GetValue(0), reader.GetValue(1).ToString()));
                    }
                }
                reader.Close();
                command.Dispose();
            }

            return states;
        }

        public List<UDObject> LoadGuest()
        {
            List<UDObject> guests = new List<UDObject>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT g.id, a.name, a.type, COALESCE(s.str_val, dc.str_val, b.str_val, dt.str_val) FROM string_value_guest s FULL JOIN attribute_value_guest av ON s.attr_val = av.id JOIN attribute_guest a ON av.attr_id = a.id JOIN guest g ON av.guest_id = g.id FULL JOIN decimal_value_guest dc ON dc.attr_val = av.id FULL JOIN boolean_value_guest b ON b.attr_val = av.id FULL JOIN date_value_guest dt ON dt.attr_val = av.id;"
                                            , connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        UDObject guest = guests.Find(g => g.Id == (int)reader.GetValue(0));
                        if (guest == null)
                        {
                            guest = new UDObject((int)reader.GetValue(0));
                            guests.Add(guest);
                        }                         
                        guest.Attributes.Add(new UAttribute(reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString()));
                    }
                }
                reader.Close();
                command.Dispose();
            }

            return guests;
        }

        public USerializableList Configure()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("CREATE TABLE department (id int IDENTITY (1, 1) NOT NULL, name varchar (50) NOT NULL, description varchar (300), CONSTRAINT PK_department_id PRIMARY KEY CLUSTERED (id));"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("CREATE TABLE employee (id int IDENTITY (1, 1) NOT NULL, FIO varchar (100) NOT NULL, login varchar (50) NOT NULL, dep_id int NOT NULL, CONSTRAINT PK_employee_id PRIMARY KEY CLUSTERED (id));"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("ALTER TABLE employee WITH CHECK ADD CONSTRAINT [FK_employee_department] FOREIGN KEY (dep_id) REFERENCES department (id);"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("CREATE TABLE process (id int IDENTITY (1, 1) NOT NULL, name varchar (50) NOT NULL, description varchar (300), CONSTRAINT PK_process_id PRIMARY KEY CLUSTERED (id));"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("CREATE TABLE subprocess (id int IDENTITY (1, 1) NOT NULL, name varchar (50) NOT NULL, process_id int NOT NULL, stage_number int NOT NULL, description varchar (300), CONSTRAINT PK_subprocess_id PRIMARY KEY CLUSTERED (id));"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("ALTER TABLE subprocess  WITH CHECK ADD CONSTRAINT [FK_subprocess_process] FOREIGN KEY (process_id) REFERENCES process (id);"
                                            , connection);
                command.Dispose();
                command.ExecuteNonQuery();

                command = new SqlCommand("CREATE TABLE sbprc_gateway (id int IDENTITY (1, 1) NOT NULL, exit_sbprc_id int NOT NULL, enter_sbprc_id int NOT NULL, CONSTRAINT PK_sbprc_gateway_id PRIMARY KEY CLUSTERED (id));"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("ALTER TABLE sbprc_gateway  WITH CHECK ADD CONSTRAINT [FK_sbprc_gateway_subprocess_exit] FOREIGN KEY (exit_sbprc_id) REFERENCES subprocess (id);"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("ALTER TABLE sbprc_gateway  WITH CHECK ADD CONSTRAINT [FK_sbprc_gateway_subprocess_enter] FOREIGN KEY (enter_sbprc_id) REFERENCES subprocess (id);"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("CREATE TABLE object (id int IDENTITY (1, 1) NOT NULL, name varchar (50) NOT NULL, table_prefix varchar (50) NOT NULL, description varchar (300), CONSTRAINT PK_obj_id PRIMARY KEY CLUSTERED (id));"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("CREATE TABLE state (id int IDENTITY (1, 1) NOT NULL, name varchar (50) NOT NULL, CONSTRAINT PK_state_id PRIMARY KEY CLUSTERED (id));"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("CREATE TABLE state_enabled (id int IDENTITY (1, 1) NOT NULL, obj_id int NOT NULL, state_id int NOT NULL, description varchar (300), CONSTRAINT PK_state_enabled_id PRIMARY KEY CLUSTERED (id));"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("ALTER TABLE state_enabled  WITH CHECK ADD CONSTRAINT [FK_state_enabled_object] FOREIGN KEY (obj_id) REFERENCES object (id);"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("ALTER TABLE state_enabled  WITH CHECK ADD CONSTRAINT [FK_state_enabled_state] FOREIGN KEY (state_id) REFERENCES state (id);"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("CREATE TABLE sbprc_membership (id int IDENTITY (1, 1) NOT NULL, sbprc_id int NOT NULL, obj_id int NOT NULL, CONSTRAINT PK_sbprc_membership_id PRIMARY KEY CLUSTERED (id));"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("ALTER TABLE sbprc_membership  WITH CHECK ADD CONSTRAINT [FK_sbprc_membership_subprocess] FOREIGN KEY (sbprc_id) REFERENCES subprocess (id);"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("ALTER TABLE sbprc_membership  WITH CHECK ADD CONSTRAINT [FK_sbprc_membership_object] FOREIGN KEY (obj_id) REFERENCES object (id);"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("CREATE TABLE sbprc_state_requirement (id int IDENTITY (1, 1) NOT NULL, mbrship_id int NOT NULL, state_ena_id int NOT NULL, CONSTRAINT PK_sbprc_state_requirement_id PRIMARY KEY CLUSTERED (id));"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("ALTER TABLE sbprc_state_requirement  WITH CHECK ADD CONSTRAINT [FK_sbprc_state_requirement_sbprc_membership] FOREIGN KEY (mbrship_id) REFERENCES sbprc_membership (id);"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("ALTER TABLE sbprc_state_requirement  WITH CHECK ADD CONSTRAINT [FK_sbprc_state_requirement_state_enabled] FOREIGN KEY (state_ena_id) REFERENCES state_enabled (id);"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("CREATE TABLE prc_execution (id int IDENTITY (1, 1) NOT NULL, prc_id int NOT NULL, emp_id int NOT NULL, cur_stage int NOT NULL, CONSTRAINT PK_prc_execution_id PRIMARY KEY CLUSTERED (id));"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("ALTER TABLE prc_execution  WITH CHECK ADD CONSTRAINT [FK_prc_execution_process] FOREIGN KEY (prc_id) REFERENCES process (id);"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("ALTER TABLE prc_execution  WITH CHECK ADD CONSTRAINT [FK_prc_execution_employee] FOREIGN KEY (emp_id) REFERENCES employee (id);"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("CREATE TABLE state_value (id int IDENTITY (1, 1) NOT NULL, obj_row_id int NOT NULL, state_ena_id int NOT NULL, CONSTRAINT PK_state_value_id PRIMARY KEY CLUSTERED (id));"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand("ALTER TABLE state_value  WITH CHECK ADD CONSTRAINT [FK_state_value_state_enabled] FOREIGN KEY (state_ena_id) REFERENCES state_enabled (id);"
                                            , connection);
                command.ExecuteNonQuery();
                command.Dispose();

                return null;
            }
        }
    }
}
