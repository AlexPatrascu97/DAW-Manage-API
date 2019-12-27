using ShopDAW.Domain.Models;
using ShopDAW.Domain.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Domain.ExtensionMethods
{
	public static class ModelsExtensionMethods
	{

		public static Order ToDTOOrder(this GeneralOrderRequest request)
		{
			return new Order
			{
				Id = request.Id,
				User = request.User,
				UserId = request.UserId,
				Product = request.Product,
				ProductId = request.ProductId,
				Quantity = request.Quantity

			};
		}

		public static Product ToDTO(this GeneralProductRequest request)
		{
			return new Product
			{
				Id = request.Id,
				Name = request.Name,
				Price = request.Price,
				Description = request.Description,
				Category = request.Category,
				Quantity = request.Quantity

			};
		}

		public static User ToDTOUser(this GeneralUserRequest request)
		{
			return new User
			{
				Id = request.Id,
				Username = request.Username,
				Password = request.Password,
				Email= request.Email,
				FirstName = request.FirstName,
				LastName = request.LastName,
				Role = request.Role

			};
		}
		public static Employee ToDTOEmployee(this GeneralEmployeeRequest request)
		{
			return new Employee

			{
				Id = request.Id,
				FirstName = request.FirstName,
				LastName = request.LastName,
				Post = request.Post,
				StartingDay = request.StartingDay,
				LastDay = request.LastDay,
				Salary = request.Salary


			};
		}

		

		public static Product ToDTO(this GeneralProductRequest request, int id)
		{
			return new Product
			{
				Id = id,
				Name = request.Name,
				Price = request.Price,
				Description = request.Description,
				Category = request.Category,
				Quantity = request.Quantity

			};
		}

		public static User ToDTOUser(this GeneralUserRequest request, int id)
		{
			return new User
			{
				Id = request.Id,
				Username = request.Username,
				Password = request.Password,
				Email = request.Email,
				FirstName = request.FirstName,
				LastName = request.LastName,
				Role = request.Role
				


			};
		}

		public static Employee ToDTOEmployee(this GeneralEmployeeRequest request,int id)
		{
			return new Employee

			{
				Id = request.Id,
				FirstName = request.FirstName,
				LastName = request.LastName,
				Post = request.Post,
				StartingDay = request.StartingDay,
				LastDay = request.LastDay,
				Salary = request.Salary


			};
		}
		public static Order ToDTOOrder(this GeneralOrderRequest request,int id)
		{
			return new Order
			{
				Id = request.Id,
				User = request.User,
				UserId = request.UserId,
				Product = request.Product,
				ProductId = request.ProductId,
				Quantity = request.Quantity
			};
		}

		public static Provider ToDTOProvider(this GeneralProviderRequest request, int id)
		{
			return new Provider
			{
				Id = request.Id,
				Address = request.Address,
				PayDay = request.PayDay,
				Payed =	 request.Payed,
				Payment = request.Payment,
				Name = request.Name
			};
		}

		public static Provider ToDTOProvider(this GeneralProviderRequest request)
		{
			return new Provider
			{
				Id = request.Id,
				Address = request.Address,
				PayDay = request.PayDay,
				Payed = request.Payed,
				Payment = request.Payment,
				Name = request.Name
			};
		}

	}
}

