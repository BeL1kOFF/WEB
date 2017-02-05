using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Ninject.Infrastructure.Language;
using Store.Domain.Entities;

namespace WebUI.Models
{
    public class MyViewModel
    {
        public IEnumerable<A> MyColl
        {
            get
            {
            List<A> list = new List<A>();
            list.Add(new A
            {
                Id = 1, Name = "First A",
                BB = new List<B>()
                {
                   new B() { Id = 1, Name = "B1", CC = new List<C>()
                    {
                        new C() {Id = 1, Name  = "C1"},
                        new C() {Id = 2, Name  = "C2"}
                    }},
                    new B() { Id = 2, Name = "B2", CC = new List<C>()
                    {
                        new C() {Id = 3, Name  = "C3"},
                        new C() {Id = 4, Name  = "C4"}
                    }}
                }
                }
            );
                list.Add(new A
                {
                    Id = 2,
                    Name = "Second A",
                    BB = new List<B>()
                {
                   new B() { Id = 3, Name = "B3", CC = new List<C>()
                    {
                        new C() {Id = 5, Name  = "C5"},
                        new C() {Id = 6, Name  = "C6"}
                    }},
                    new B() { Id = 4, Name = "B4", CC = new List<C>()
                    {
                        new C() {Id = 7, Name  = "C7"},
                        new C() {Id = 8, Name  = "C8"}
                    }}
                }
                }
            );
                return list;

            return new List<A>(); 
                
            }
            set { }
        }


        public IEnumerable<B> GetB { get; set; }

        public IEnumerable<B> GetBB(int Id)
        {
            return MyColl.Where(a=>a.Id==Id).Select(r=>r.BB).FirstOrDefault();
        }
    }
}