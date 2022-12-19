﻿using Microsoft.AspNetCore.Mvc;
using WebProgramlamaProje.Entity;

namespace WebProgramlamaProje.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult AdminGetAllBlogs()
        {
            //Bütün blogları listele
            return View();
        }

        public IActionResult DeleteBlog(int id)
        {
            //Blogları sil
            return View();
        }
        public IActionResult AuthorGetBlogs() 
        { 
            //Yazarın blogları listele
            return View(); 
        }
        [HttpGet]
        public IActionResult AuthorAddNewBlog(Blogs blog)
        {
            //Yazar yeni blog ekle get
            return View();
        }
        [HttpPost]
        public IActionResult AuthorAddNewBlog(int id)
        {
            //Yazar yeni blog ekle post
            return RedirectToAction("AuthorGetBlogs");
        }
        public IActionResult AuthorDeleteBlog(int id)
        {
            //Yazar blog sil
            return RedirectToAction("AuthorGetBlogs");
        }
        [HttpGet]
        public IActionResult AuthorUpdateBlog(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult AuthorUpdateBlog(Blogs p)
        {
            return RedirectToAction("AuthorGetBlogs");
        }
    }
}