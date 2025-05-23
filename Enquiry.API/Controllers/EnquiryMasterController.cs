﻿using Enquiry.API.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Enquiry.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("allowCors")]
    public class EnquiryMasterController : ControllerBase
    {
        private readonly EnquiryDBcontext _context;

        public EnquiryMasterController(EnquiryDBcontext context)
        {
            _context = context;
        }

        [HttpGet("GetAllStatus")]
        public List<EnquiryStatus> GetEnquiryStatuses()
        {
            var list = _context.EnquiryStatus.ToList();
            return list;
        }

        [HttpGet("GetAllTypes")]
        public List<EnquiryType> GetAllTypes()
        {var list= _context.EnquiryType.ToList();
            return list;    

        }

        [HttpGet("GetAllEnquiry")]
        public List<EnquiryModel> GetAllEnquiry()
        {
            var list = _context.Enquiry.ToList();
            return list;
        }

        [HttpPost("CreateNewEnquiry")]
        public EnquiryModel AddNewEnquiry(EnquiryModel obj)
        {
            obj.createdDate = DateTime.Now;
            _context.Enquiry.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        [HttpPut("UpdateEnquiry")]
        public EnquiryModel Update(EnquiryModel obj)
        {
            var record = _context.Enquiry.SingleOrDefault(m=>m.enquiryId== obj.enquiryId);
            if(record != null)
            {
                record.resolution= obj.resolution;
                record.enquiryStatusId= obj.enquiryStatusId;
                _context.SaveChanges();
            }
            return obj;
        }

        [HttpDelete("DeleteEnquiryById")]
        public bool DeleteEnquiryById(int id)
        {
            var record = _context.Enquiry.SingleOrDefault(m => m.enquiryId == id);
            if (record != null)
            {
                _context.Enquiry.Remove(record);   
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
           
        }

    }
}
