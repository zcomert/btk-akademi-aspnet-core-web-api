using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.RequestFeatures
{
	public abstract class RequestParameters
    {
		const int maxPageSize = 50;
		
		// Auto-implemented property 
        public int PageNumber { get; set; }
		
		// Full-property
		private int _pageSize;

		public int PageSize
		{
			get { return _pageSize; }
			set { _pageSize = value > maxPageSize ? maxPageSize : value; }
		}

		public String? OrderBy { get; set; }
		public String? Fields { get; set; }

	}
}
