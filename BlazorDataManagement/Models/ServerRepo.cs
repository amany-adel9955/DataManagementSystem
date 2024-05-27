namespace BlazorDataManagement.Models
{
	public static class ServerRepo
	{
		private static List<Server> Servers = new List<Server>()
		{
			new Server{Id = 1, Name = "Server1" , City = "c1"},
			new Server{Id = 2, Name = "Server2" , City = "c2"},
			new Server{Id = 3, Name = "Server3" , City = "c3"},
			new Server{Id = 4, Name = "Server4" , City = "c4"},
			new Server{Id = 5, Name = "Server5" , City = "c2"},
			new Server{Id = 6, Name = "Server6" , City = "c3"},
			new Server{Id = 7, Name = "Server7" , City = "c1"},
			new Server{Id = 8, Name = "Server8" , City = "c2"},
			new Server{Id = 9, Name = "Server9" , City = "c4"},
			new Server{Id = 10, Name = "Server10" , City = "c3"},
			new Server{Id = 11, Name = "Server11" , City = "c1"},
			new Server{Id = 12, Name = "Server12" , City = "c2"}

		};

		public static void AddServer(Server server)
		{
			var maxId = Servers.Max(d => d.Id);
			server.Id = maxId + 1;
			Servers.Add(server);
		}

		public static List<Server> GetAllServers() => Servers;

		public static List<Server> GetServerByCity(string city)
		{
			return Servers.Where(d => d.City.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();
		}

		public static Server? ServerById(int id)
		{
			var server = Servers.FirstOrDefault(d => d.Id == id);
			if(server is null)
			{
				return new Server
				{
					Id = server.Id,
					Name = server.Name,
					City = server.City,
					IsOnline = server.IsOnline

				};
			}
			return null;
		}

		public static void UpdateServer(int id , Server server)
		{
			if (id != server.Id) return;
			var ServerToUpdate = Servers.FirstOrDefault(d => d.Id == id);
			if(ServerToUpdate is not null)
			{
				ServerToUpdate.Name = server.Name;
				ServerToUpdate.City = server.City;
				ServerToUpdate.IsOnline = server.IsOnline;
			}
		}

		public static void DeleteServer(int id)
		{
			var server = Servers.FirstOrDefault(d => d.Id == id);
			if(server is not null)
			{
				Servers.Remove(server);
			}
		}

		public static List<Server> SearchServer(string serverFilter)
		{
			return Servers.Where(d => d.Name.Contains(serverFilter, StringComparison.OrdinalIgnoreCase)).ToList();
		}
	}
}
