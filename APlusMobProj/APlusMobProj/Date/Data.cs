using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using APlusMobProj.Models;

namespace APlusMobProj.Data
{
	class Data
	{
        readonly SQLiteConnection db;
        public Data(string connectionString)
        {
            db = new SQLiteConnection(connectionString);
            db.CreateTable<AplusModel>();
        }
        public IEnumerable<AplusModel> GetProject()
        {
            return db.Table<AplusModel>().ToList();
        }
        public AplusModel GetProject(int id)
        {
            return db.Table<AplusModel>()
                                .Where(i => i.ID == id)
                                .FirstOrDefault();
        }
        public int SaveProject(AplusModel project)
        {
            if (project.ID != 0)
            {
                return db.Update(project);
            }
            else
            {
                return db.Insert(project);
            }
        }
        public int DeleteProject(int id)
        {
            return db.Delete<AplusModel>(id);
        }
    }
}
