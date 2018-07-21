using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenFinal.Common;
using ExamenFinal.Common.api.controller;
using ExamenFinal.Estudiante.application;
using Microsoft.AspNetCore.Mvc;

namespace ExamenFinal.Estudiante.api.controller
{

    public class EstudianteController : Controller
    {
        IEstudianteApplicationService _estudianteApplicationService;
        ResponseHandler responseHandler;

        #region ctor

        public EstudianteController(IEstudianteApplicationService estudianteApplicationService)
        {
            _estudianteApplicationService = estudianteApplicationService;
            responseHandler = new ResponseHandler();
        }

        #endregion

        #region Methods

        [Route("/api/Estudiante/GetEstudiantePorNivel/{idNivelEstudio}")]
        [HttpGet]
        public IActionResult GetEstudiantePorNivel(int idNivelEstudio)
        {
            try
            {
                return Ok(_estudianteApplicationService.GetEstudiantePorNivel(idNivelEstudio));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(this.responseHandler.getAppCustomErrorResponse(ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(Constantes.HttpStatus.ErrorServer, this.responseHandler.getAppExceptionResponse());
            }
        }


        [Route("/api/Estudiante/getNivelEstudio")]
        [HttpGet]
        public IActionResult getNivelEstudio()
        {
            try
            {
                return Ok(_estudianteApplicationService.getNivelEstudio());
            }
            catch (ArgumentException ex)
            {
                return BadRequest(this.responseHandler.getAppCustomErrorResponse(ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(Constantes.HttpStatus.ErrorServer, this.responseHandler.getAppExceptionResponse());
            }
        }




        [Route("/api/Estudiante/getMontoStudies/{id}")]
        [HttpGet]
        public IActionResult getMontoStudies(int id)
        {
            try
            {
                return Ok(_estudianteApplicationService.getMontoStudies(id));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(this.responseHandler.getAppCustomErrorResponse(ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(Constantes.HttpStatus.ErrorServer, this.responseHandler.getAppExceptionResponse());
            }
        }


        #endregion


    }
}