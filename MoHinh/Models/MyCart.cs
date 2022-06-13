using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MoHinh.Models
{
    public class MyCart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        public virtual void AddItem(Hinh hinh, int quantity)
        {
            CartLine line = Lines
            .Where(b => b.Hinh.HinhID == hinh.HinhID)
            .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Hinh = hinh,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public virtual void RemoveLine(Hinh hinh) =>
        Lines.RemoveAll(l => l.Hinh.HinhID == hinh.HinhID);
        public decimal ComputeTotalValue() =>
        Lines.Sum(e => e.Hinh.Gia * e.Quantity);
        public virtual void Clear() => Lines.Clear();
    }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Hinh Hinh { get; set; }
        public int Quantity { get; set; }
    }
}

