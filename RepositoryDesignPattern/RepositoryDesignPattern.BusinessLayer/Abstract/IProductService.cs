﻿using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.BusinessLayer.Abstract
{
	public interface IProductService : IGenericService<Product>
	{
		List<Product> TProductListWithCategory();
	}
}
