﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.SqlClient;
using System.Data;
using MVCLaboratorio.Utilerias;
using MVCLaboratorio.Models;

namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LIIGabriel()
        {
            //obtener la info de los videos de la BD
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideos = new List<Video>();

            //convertir el DataTable a una lista de videos List<Video>
            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["IdVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstVideos.Add(videoAux);
            }
            
            return View(lstVideos);

        }
        public ActionResult IrvingDeLaGarza()
        {
           
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

<<<<<<< HEAD
        public ActionResult CristianGzz()
        {
            //obtener la info de los videos de la BD
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideos = new List<Video>();

            //convertir el DataTable a una lista de videos List<Video>
            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["IdVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstVideos.Add(videoAux);
            }

            return View(lstVideos);

        }
=======
<<<<<<< HEAD
            List<Video> lstVideos = new List<Video>();
=======
        //Controlador de Mauricio 
        public ActionResult MauricioHdz17()
        {
            //Traer la información de la BD
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
>>>>>>> 52dbeeaf9557e6ab0b811f85aa10bd97490744c9

            List<Video> lstVideos = new List<Video>();
            //Ciclo para recorrer el arreglo
            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["IdVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstVideos.Add(videoAux);
            }

            return View(lstVideos);
        }
        public ActionResult StephannieMtz()
        {
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo",CommandType.StoredProcedure);
                List<Video> lstVideos = new List<Video>();

            foreach(DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["idVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());
                lstVideos.Add(videoAux);
            }
            return View(lstVideos);
        }

        public ActionResult JoaquinFlores()
        {
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Video> lstVideos = new List<Video>();

            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["idVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());
                lstVideos.Add(videoAux);
            }
            return View(lstVideos);
        }
>>>>>>> 186708834a0c60fc4941bef9a778daf32d4c6424

            
            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["IdVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstVideos.Add(videoAux);
            }

            return View(lstVideos);

        }
    }
}
