using System;
using System.Collections.Generic;
using System.Text;

namespace Receipt_Organizer_App
{
    class Account
    {
        #region Properties
        /// <summary>
        /// Users EmailAddress
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Monthly
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Type Food/Gas/etc...
        /// </summary>
        public string ReceiptType { get; set; }
        /// <summary>
        /// Number of Receipts
        /// </summary>
        public int NumberOfReceipts { get; set; }
        /// <summary>
        /// Total Balance
        /// </summary>
        public decimal Balance { get; set; }
        #endregion
        #region Method
        /// <summary>
        /// Total Balance
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public decimal ReceiptSum(decimal amount)
        {
            Balance += amount;
        }
        /// <summary>
        /// Number of Receipts
        /// </summary>
        /// <param name="receipt"></param>
        public void Receipts(int receipt)
        {
            NumberOfReceipts += receipt;
        }
        


    }
}
