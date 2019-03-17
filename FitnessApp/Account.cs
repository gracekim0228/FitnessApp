using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessApp
{
    ///<summary>
    /// Fitness account where you can record weight and calories
    ///</summary>
    class Account
    {
        #region Properties
        /// <summary>
        /// Name of the user
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Email address of the user
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Current weight of the user
        /// </summary>
        public decimal Weight { get; set; }
        /// <summary>
        /// Total calories recommended to consume daily
        /// </summary>
        public int CalorieBudget { get; set; }
        /// <summary>
        /// Net calories consumed by user
        /// </summary>
        public int NetCalories { get; set; }
        /// <summary>
        /// Today's date
        /// </summary>
        public DateTime Date { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Record the calories consumed by eating
        /// </summary>
        /// <param name="calories">calories consumed</param>
        public void CaloriesConsumed(int calories)
        {
            NetCalories += calories;
        }
        /// <summary>
        /// Record the calories burned by exercising
        /// </summary>
        /// <param name="calories">calories burned</param>
        public void CaloriesBurned(int calories)
        {
            NetCalories -= calories;
        }
        #endregion
    }
}
