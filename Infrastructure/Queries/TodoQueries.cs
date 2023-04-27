
using Application.QueriesAbstruction.Queries;
using Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Queries
{
    public class TodoQueries : ITodoQueries
    {
        public IConfiguration _Configuration { get; }
        public string connectionstring;
        List<Todo> TodoItems;
        public TodoQueries(IConfiguration configuration)
        {
            _Configuration = configuration;
            connectionstring = _Configuration.GetConnectionString("DemoDb");
            TodoItems = new List<Todo>();
        }



        public List<Todo> GetTodoList()
        {
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                string query = "select * from Todo";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            var tododata = new Todo
                            {
                                ID = (int)reader["ID"],
                                TodoName = (string)reader["TodoName"],
                                Status = (string)reader["Status"]
                            };
                            TodoItems.Add(tododata);
                        }
                        return TodoItems;
                    }
                }
            }


        }
    }
}
