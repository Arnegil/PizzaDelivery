﻿using System.Collections.Generic;
using System.Text;
using PizzaDelivery.ViewModel.ViewModels.PersonalPages.Client;
using PizzaDelivery.ViewModel.ViewModels.PersonalPages.Deliveryman;
using PizzaDelivery.ViewModel.ViewModels.PersonalPages.Operator;

namespace PizzaDelivery.ViewModel.Interfaces
{
    public interface IPesonalPageVMService
    {
        PersonalInfoVM GetPersonalInfo();
        void SavePersonalInfo(PersonalInfoVM personalInfo);
        OrderHistoryVM GetOrderHistory();

        NewOrdersVM GetNewOrders();
        PersonalOrdersVM GetPersonalOrders();

        OrdersToDeliveryVM GetOrdersToDelivery();
    }
}