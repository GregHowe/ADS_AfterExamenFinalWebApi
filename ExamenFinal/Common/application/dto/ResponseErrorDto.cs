using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Common.application.dto
{
    public class ResponseErrorDto
    {
        public int httpStatus { get; set; }
        public List<ErrorDto> errors { get; set; }

        public ResponseErrorDto()
        {
        }

        public ResponseErrorDto(List<ErrorDto> errors)
        {
            this.errors = errors;
        }
    }
}
