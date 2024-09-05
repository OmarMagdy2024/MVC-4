using Microsoft.EntityFrameworkCore;
using MVC_4_BLL.InterFaces;
using MVC_DAL.Data;
using MVC_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_4_BLL.Repositorys
{
    public class DepartmentRepository:IDepartmentRepository
    {
        private readonly AppDBContext _dbContext;
        public DepartmentRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Add(Department department)
        {
            _dbContext.Department.Add(department);
            return _dbContext.SaveChanges();
        }
        public int Delete(Department department)
        {
            _dbContext.Department.Remove(department);
            return _dbContext.SaveChanges();
        }
        public IEnumerable<Department> GetAll()
        {
            return _dbContext.Department.AsNoTracking().ToList();
        }
        public Department GetById(int id)
        {
            return _dbContext.Department.Find(id);
            //return _dbContext.Find<Department>(id);
        }
        public int Update(Department department)
        {
            _dbContext.Department.Update(department);
            return _dbContext.SaveChanges();
        }
    }
}
