using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocWay.Application.DTO
{
    public class PaginationDTO
    {
        public int Page { get; set; } = 1;

        private int recordsByPages = 10;
        private readonly int maximumNumberRecordsByPage = 50;

        public int RecordsByPages
        {
            get
            {
                return recordsByPages;
            }
            set
            {
                recordsByPages = (value > maximumNumberRecordsByPage) ? maximumNumberRecordsByPage : value;
            }
        }
    }
}
