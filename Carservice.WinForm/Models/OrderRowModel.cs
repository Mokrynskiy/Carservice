using DevExpress.Mvvm.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace CarService.WinForm.Models
{
    [POCOViewModel]
    public class OrderRowModel
    {
        public virtual int Id { get; set; }
        public virtual DateTime OpenDate { get; set; }
        public virtual DateTime DueDate { get; set; }
        public virtual DateTime? CloseDate { get; set; }
        public virtual string Client { get; set; }
        public virtual string Car { get; set; }
        public virtual decimal Sum { get; set; }
    }
}
