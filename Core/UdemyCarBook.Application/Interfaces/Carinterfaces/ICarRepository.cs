using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.Carinterfaces
{
	public interface ICarRepository
	{
		List<Car> GetCarsListWithBrands();
		List<Car> GetLast5CarsWithBrands();
		int GetCarCount();
	
	}
}
