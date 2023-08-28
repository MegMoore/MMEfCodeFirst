// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using MMEfCodeFirst.Models;
using System.ComponentModel;

var _context = new SalesContext();



var orders = _context.Orders.
                            Include(x => x.OrderLines).
                            ThenInclude(x => x.Item).
                            Where(x => x.Id == 1);

var x = 0;

/*
 * var orders = from o in _context.Orders
             join ol in _context.OrderLines
                on o.Id equals ol.OrderId
             join i in _context.Items
                 on ol.ItemId equals i.Id
             select new
             {
                 Order = o.Id, 
                 o.Description,
                 Product = i.Name,
                 ol.Quantity,
                 i.Price,
                 LineTotal = ol.Quantity * i.Price
             };
*/

//foreach (var item in orders.ToList()) 
//{
  //  Console.WriteLine($"{item.Order} | {item.Description} | {item.Product} | {item. Quantity} | {item.Price} | {item.LineTotal} ");
//}