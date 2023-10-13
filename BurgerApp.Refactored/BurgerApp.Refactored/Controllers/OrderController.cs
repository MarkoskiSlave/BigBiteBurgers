using Microsoft.AspNetCore.Mvc;
using BurgerApp.Services.Interfaces;
using BurgerApp.Services.Implementations;
using BurgerApp.Models.Domain;

namespace BurgerApp.Refactored.Controllers
{
    public class OrderController : Controller
    {
        //private IOrderService _orderService;
        //public OrderController()
        //{
        //    _orderService = new OrderService();
        //}
        //public IActionResult SeeOrders()
        //{
        //    List<OrderDetailsViewModel> orderViewModels = _orderService.GetAllOrders();
        //    return View(orderViewModels);
        //}
        //public IActionResult CreateOrder()
        //{
        //    OrderViewModel orderViewModel = new OrderViewModel();
        //    return View(orderViewModel);
        //}
        //public IActionResult CreateOrderPost(OrderViewModel orderViewModel)
        //{
        //    try
        //    {
        //        _orderService.CreateOrder(orderViewModel);
        //        return RedirectToAction("SeeOrders");
        //    }
        //    catch (Exception e)
        //    {
        //        return View("UnderstandableError");
        //    }
        //}
        //public IActionResult EditOrder(int? id)
        //{
        //    if (id == null)
        //    {
        //        return View("UnderstandableError");
        //    }

        //    Order orderDb = _orderService.GetOrderById(id.Value);
        //    if (orderDb == null)
        //    {
        //        return View("UnderstandableError");
        //    }
        //    OrderViewModel orderViewModel = new OrderViewModel
        //    {
        //        Id = orderDb.OrderId,
        //        Address = orderDb.Address,
        //        PaymentMethond = orderDb.PaymentMethod
        //    };
        //    return View(orderViewModel);
        //}
        //[HttpPost]
        //public IActionResult EditOrderPost(OrderViewModel orderViewModel)
        //{
        //    try
        //    {
        //        _orderService.UpdateOrder(orderViewModel);
        //        return RedirectToAction("SeeOrders");
        //    }
        //    catch (Exception ex)
        //    {
        //        return View("UnderstandableError");
        //    }
        //}
        //public IActionResult DeleteOrder(int? id)
        //{
        //    try
        //    {
        //        _orderService.DeleteOrder(id.Value);
        //        return RedirectToAction("SeeOrders");
        //    }
        //    catch (Exception)
        //    {
        //        return View("UnderstandableError");
        //    }
        //}
    }
}
