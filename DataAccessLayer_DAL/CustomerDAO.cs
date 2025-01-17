﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class CustomerDAO : GeneralDAO
    {
        public DataSet getAllCustomer()
        {
            return getAll("Customer");
        }
        public DataSet searchByName(string name)
        {
            return search("Customer", "DisplayNameCustomer like '%" + name + "%' or " +
                                      "DisplayNameCustomer like '%" + name + "%' ");
        }
        public SqlDataReader findById(string id)
        {
            getConnection();
            SqlDataReader dr = findById("Customer", " CustomerId= '" + id + "' ");
            //closeConnection();
            return dr;
        }

        public int deleteCustomer(string id)
        {
            try
            {
                string sql = "delete [Customer] where CustomerId ='" + id + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }


        public int updateCustomer(Customer customer)
        {
            try
            {
                string sql = "update [Customer] set DisplayNameCustomer = '" + customer.DisplayNameCustomer + "', " +
                             "Address = '" + customer.Address + "', " +
                             "Phone = '" + customer.Phone + "', " +
                             "Email = '" + customer.Email + "', " +
                             "MoreInfo = '" + customer.MoreInfo + "' " +
                             "where CustomerId = '" + customer.CustomerId + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }


        public int createCustomer(Customer customer)
        {
            try{
                string sql = "insert into [Customer] (CustomerId, DisplayNameCustomer, Address, Phone, Email, MoreInfo) " +
                                 "values ('" + customer.CustomerId + "', '" + customer.DisplayNameCustomer + "', '" + customer.Address + "', '" + customer.Phone + "', '" + customer.Email + "', '" + customer.MoreInfo + "')";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }
    }
}
