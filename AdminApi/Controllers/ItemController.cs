﻿using AdminApi.Models.App.Category;
using AdminApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.Item;
using AdminApi.DTO.App;
using AdminApi.Models.Helper;
using System.Linq;
using System;
using Microsoft.AspNetCore.Authorization;
using AdminApi.DTO.App.ItemDTO;
using System.Collections.Generic;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]

    public class ItemController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Item> _itemRepo;
        private readonly ISqlRepository<ItemImage> _itemimageRepo;
        public ItemController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Item> itemRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration, ISqlRepository<ItemImage> itemimageRepo)
        {
            _config = config;
            _context = context;
            _itemRepo = itemRepo;
            _itemimageRepo = itemimageRepo;

        }
        
        [HttpPost]
        public ActionResult CreateItem(ItemDTO itemDTO)
        {
            var objCheck = _context.Items.SingleOrDefault(opt => opt.ItemName == itemDTO.ItemName && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {

                    Item item = new Item();
                    item.ItemName = itemDTO.ItemName;
                    item.VendorId = itemDTO.VendorId;
                    item.CategoryId = itemDTO.CategoryId;
                    item.SalePrice = itemDTO.SalePrice;
                    item.MRP = itemDTO.MRP;
                    item.DiscountAmount = itemDTO.DiscountAmount;
                    item.ColorCode = itemDTO.ColorCode;
                    item.Status = itemDTO.Status;
                    item.GSTAmount = itemDTO.GSTAmount;
                    item.GSTId = itemDTO.GSTId;
                    item.TaxType = itemDTO.TaxType;
                    item.HNSCode = itemDTO.HNSCode;
                    item.Description = itemDTO.Description;
                    item.CreatedBy = itemDTO.CreatedBy;
                    item.CreatedOn = DateTime.Now;
                    var obj = _itemRepo.Insert(item);

                    for (int i = 0; i < itemDTO.ItemImageDTOs.Count; i++)
                    {
                        ItemImage itemImage = new ItemImage();
                        itemImage.ItemId = obj.ItemId;
                        itemImage.MainImage = itemDTO.ItemImageDTOs[i].MainImage;
                        itemImage.CreatedBy = itemDTO.CreatedBy;
                        itemImage.CreatedOn = DateTime.Now;
                        var Itemobj = _itemimageRepo.Insert(itemImage);
                    }


                    return Ok(itemDTO);


                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate Item.." });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //public ActionResult CreateItem(ItemDTO itemDTO)
        //{
        //    var objCheck = _context.Items.SingleOrDefault(opt => opt.ItemName == itemDTO.ItemName && opt.IsDeleted == false);
        //    try
        //    {
        //        if (objCheck == null)
        //        {
        //            Item item = new Item();
        //            item.ItemName = itemDTO.ItemName;
        //            item.VendorId = itemDTO.VendorId;
        //            item.CategoryId = itemDTO.CategoryId;
        //            item.SalePrice = itemDTO.SalePrice;
        //            item.MRP = itemDTO.MRP;
        //            item.DiscountAmount = itemDTO.DiscountAmount;
        //            item.ColorCode = itemDTO.ColorCode;
        //            item.Status = itemDTO.Status;
        //            item.GSTAmount = itemDTO.GSTAmount;
        //            item.GSTId = itemDTO.GSTId;
        //            item.TaxType = itemDTO.TaxType;
        //            item.HNSCode = itemDTO.HNSCode;
        //            item.Description = itemDTO.Description;
        //            item.CreatedBy = itemDTO.CreatedBy;
        //            item.CreatedOn = DateTime.Now;
        //            var obj = _itemRepo.Insert(item);

        //            // Insert main image
        //            ItemImage mainImage = new ItemImage();
        //            mainImage.ItemId = obj.ItemId;
        //            mainImage.MainImage = itemDTO.ItemImageDTOs.FirstOrDefault()?.MainImage; // Use the first image as the main image
        //            mainImage.Image = mainImage.MainImage; // Assuming the first image is also the main image
        //            mainImage.CreatedBy = itemDTO.CreatedBy;
        //            mainImage.CreatedOn = DateTime.Now;
        //            var mainImageObj = _itemimageRepo.Insert(mainImage);

        //            // Insert additional images
        //            foreach (var imageDTO in itemDTO.ItemImageDTOs.Skip(1)) // Skip the first image (main image)
        //            {
        //                ItemImage additionalImage = new ItemImage();
        //                additionalImage.ItemId = obj.ItemId;

        //                additionalImage.Image = imageDTO.Image;
        //                additionalImage.CreatedBy = itemDTO.CreatedBy;
        //                additionalImage.CreatedOn = DateTime.Now;
        //                var additionalImageObj = _itemimageRepo.Insert(additionalImage);
        //            }

        //            return Ok(itemDTO);
        //        }
        //        else if (objCheck != null)
        //        {
        //            return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate Item.." });
        //        }
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }
        //}

        [HttpGet]
        public ActionResult AllItemList()
        {
            try
            {
                var list = (from u in _context.Items
                            join a in _context.Vendors on u.VendorId equals a.VendorId
                            join b in _context.Category on u.CategoryId equals b.CategoryId
                            join c in _context.ItemImage on u.ItemId equals c.ItemId 
                            select new
                            {
                                u.ItemId,
                                a.VendorName,
                                c.MainImage,
                                b.CategoryName,
                                u.ItemName,
                                u.CreatedOn,
                                u.IsDeleted,
                                u.VendorId,
                                u.CategoryId,
                                u.SalePrice,
                                u.MRP,
                                u.DiscountAmount,
                                u.TaxType,
                                u.HNSCode,
                                u.GSTId,
                                u.GSTAmount,
                                u.Status,
                                u.Description,
                            }).Where(x => x.IsDeleted == false);
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{ItemId}")]
        public ActionResult GetSingleItem(int ItemId)
        {
            try
            {
                var category = _itemRepo.SelectById(ItemId);

                return Ok(category);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpPost]
        public ActionResult UpdateItem(ItemUpdateDTO itemUpdateDTO)
        {
            try
            {
                var item = _context.Items.SingleOrDefault(opt => opt.ItemId == itemUpdateDTO.ItemId);
                if (item != null)
                {
                    item.ItemName = itemUpdateDTO.ItemName;
                    item.VendorId = itemUpdateDTO.VendorId;
                    item.CategoryId = itemUpdateDTO.CategoryId;
                    item.SalePrice = itemUpdateDTO.SalePrice;
                    item.MRP = itemUpdateDTO.MRP;
                    item.DiscountAmount = itemUpdateDTO.DiscountAmount;
                    item.TaxType = itemUpdateDTO.TaxType;
                    item.Status = itemUpdateDTO.Status;
                    item.ColorCode = itemUpdateDTO.ColorCode;
                    item.GSTAmount = itemUpdateDTO.GSTAmount;
                    item.GSTId = itemUpdateDTO.GSTId;
                    item.Description = itemUpdateDTO.Description;
                    item.UpdatedBy = itemUpdateDTO.UpdatedBy;
                    item.UpdatedOn = System.DateTime.Now;

                    // Update item images
                    foreach (var imageDTO in itemUpdateDTO.UpdateItemImageDTOs)
                    {
                        ItemImage itemImage = new ItemImage(); // Initialize itemImage object
                        itemImage.ItemId = itemUpdateDTO.ItemId;
                        itemImage.MainImage = imageDTO.MainImage;
                        //itemImage.Image = imageDTO.Image;
                        itemImage.UpdatedBy = itemUpdateDTO.UpdatedBy;
                        itemImage.UpdatedOn = DateTime.Now;

                        // Add itemImage to the context
                        _context.ItemImage.Add(itemImage);
                    }

                    _context.SaveChanges();
                    return Ok(itemUpdateDTO);
                }
                else
                {
                    return NotFound(); // Return appropriate response if the item is not found
                }
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //public ActionResult UpdateItem(ItemUpdateDTO itemUpdateDTO)
        //{
        //    try
        //    {
        //        var item = _context.Items.SingleOrDefault(opt => opt.ItemId == itemUpdateDTO.ItemId);
        //        item.ItemName = itemUpdateDTO.ItemName;
        //        item.VendorId = itemUpdateDTO.VendorId;
        //        item.CategoryId = itemUpdateDTO.CategoryId;
        //        item.SalePrice = itemUpdateDTO.SalePrice;
        //        item.MRP = itemUpdateDTO.MRP;
        //        item.DiscountAmount = itemUpdateDTO.DiscountAmount;
        //        item.TaxType = itemUpdateDTO.TaxType;
        //        item.Status = itemUpdateDTO.Status;
        //        item.ColorCode = itemUpdateDTO.ColorCode;
        //        item.GSTAmount = itemUpdateDTO.GSTAmount;
        //        item.GSTId = itemUpdateDTO.GSTId;
        //        item.Description = itemUpdateDTO.Description;
        //        item.UpdatedBy = itemUpdateDTO.UpdatedBy;
        //        item.UpdatedOn = System.DateTime.Now;

        //        for (int i = 0; i < itemUpdateDTO.UpdateItemImageDTOs.Count; i++)
        //        {
        //            ItemImage itemImage = new ItemImage();
        //            itemImage.ItemId = itemUpdateDTO.ItemId;
        //            itemImage.MainImage = itemUpdateDTO.UpdateItemImageDTOs[i].MainImage;
        //            itemImage.Image = itemUpdateDTO.UpdateItemImageDTOs[i].Image;
        //            itemImage.UpdatedBy = itemUpdateDTO.UpdatedBy;
        //            itemImage.UpdatedOn = DateTime.Now;

        //        }

        //        _context.SaveChanges();
        //        return Ok(itemUpdateDTO);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }
        //}

        [HttpGet("{ItemId}/{DeletedBy}")]
        public ActionResult DeleteItem(int ItemId, int DeletedBy)
        {
            try
            {
                var item = _context.Items.SingleOrDefault(opt => opt.ItemId == ItemId);
                item.IsDeleted = true;
                item.UpdatedBy = DeletedBy;
                item.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(item);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
       


    }
}

   