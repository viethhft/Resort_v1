﻿using Resort.Models;

namespace Resort.Repo.IReponsitories
{
	public interface ICommuneRepo
	{
		public Task<List<Commune>> GetAllCommune();
		public Task<List<Commune>> GetCommuneByID(int id);
	}
}
