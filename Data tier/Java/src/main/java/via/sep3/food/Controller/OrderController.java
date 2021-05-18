package via.sep3.food.Controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;
import via.sep3.food.Model.Order;
import via.sep3.food.Service.IOrderService;

@RestController
public class OrderController {

    @Autowired
    private IOrderService OrderService;

    @GetMapping("/GetOrder")
    public Order GetOrder(@RequestParam int orderid){
        return OrderService.GetOrder(orderid);
    }

    @GetMapping("/GetUserOrders")
    public Order GetUserOrders(@RequestParam int userId){
        return OrderService.GetUserOrders(userId);
    }

    @PostMapping("/AddOrder")
    public Order AddOrder(@RequestBody Order order) {
        return OrderService.AddOrder(order);

    }
    @DeleteMapping("/RemoveOrder")
    public Order RemoveOrder(@RequestBody Order order){
        return OrderService.RemoveOrder(order);
    }

    @PutMapping("/UpdateOrder")
    public Order UpdateOrder(@RequestBody Order order){

        return OrderService.UpdateOrder(order);
    }
}