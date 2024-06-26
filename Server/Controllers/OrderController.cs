﻿using Microsoft.AspNetCore.Mvc;
using WebShop.Server.Services.OrderService;
using WebShop.Shared;
using WebShop.Shared.Models;

namespace WebShop.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<bool>>> PlaceOrder()
    {
        var result = await _orderService.PlaceOrder();
        return Ok(result);
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<OrderOverviewResponse>>>> GetOrders()
    {
        var result = await _orderService.GetOrders();
        return Ok(result);
    }

    [HttpGet("{orderId}")]
    public async Task<ActionResult<ServiceResponse<OrderDetailsResponse>>> GetOrdersDetails(int orderId)
    {
        var result = await _orderService.GetOrderDetails(orderId);
        return Ok(result);
    }
}
