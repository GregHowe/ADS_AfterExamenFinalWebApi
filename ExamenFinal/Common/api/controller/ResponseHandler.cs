﻿using ExamenFinal.Common.application.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Common.api.controller
{
    public class ResponseHandler
    {
        public ResponseDto getOkCommandResponse(string message, int StatusCode, object content = null)
        {
            ResponseDto responseDto = new ResponseDto();
            ResponseOkCommandDto responseOkCommandDto = new ResponseOkCommandDto();
            responseOkCommandDto.httpStatus = StatusCode;
            responseOkCommandDto.message = message;
            responseOkCommandDto.content = content;
            responseDto.response = responseOkCommandDto;
            return responseDto;
        }

        public ResponseDto getAppCustomErrorResponse(string errorMessages)
        {
            ResponseDto responseDto = new ResponseDto();
            string[] errors = errorMessages.Split(",");
            List<ErrorDto> errorsDto = new List<ErrorDto>();
            foreach (string error in errors)
            {
                errorsDto.Add(new ErrorDto(error));
            }
            ResponseErrorDto responseErrorDto = new ResponseErrorDto(errorsDto);
            responseErrorDto.httpStatus = Constantes.HttpStatus.BadRequest;
            responseDto.response = responseErrorDto;
            return responseDto;
        }

        public ResponseDto getAppExceptionResponse()
        {
            ResponseDto responseDto = new ResponseDto();
            List<ErrorDto> errorsDto = new List<ErrorDto>();
            errorsDto.Add(new ErrorDto("Server error"));
            ResponseErrorDto responseErrorDto = new ResponseErrorDto(errorsDto);
            responseErrorDto.httpStatus = Constantes.HttpStatus.ErrorServer;
            responseDto.response = responseErrorDto;
            return responseDto;
        }
    }
}