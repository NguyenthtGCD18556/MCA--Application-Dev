using GCD0705.AppDev.Models;
using System.Collections.Generic;

namespace GCD0705.AppDev.ViewModels
{
	public class TaskCategoriesViewModel
	{
		public Task Task { get; set; }
		public IEnumerable<Category> Categories { get; set; }
	}
}