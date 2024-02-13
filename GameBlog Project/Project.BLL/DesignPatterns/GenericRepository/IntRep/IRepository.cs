﻿using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.IntRep
{
    public interface IRepository<T>where T : BaseEntity

    {
        List<T> GetAll();
        List<T> GetActives();
        List<T> GetModifieds();
        List <T> GetDeleteds();

        void Add(T item);
        void AddRange (List<T> list);
        void Delete (T item);
        void DeleteRange(List<T> list);
        void Update (T item);
        void UpdateRange (List<T> list);
        void Destroy(T item);
        void DestroyRange(List<T> list);

        List <T> Where(Expression<Func<T, bool>> exp);
        bool Any (Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        object Select (Expression<Func<T, object>> exp);

        IQueryable<X> Select <X>(Expression<Func<T, X>> exp);

        T Find(int id);
        IQueryable<T> Take(int number);



            
    }
}
