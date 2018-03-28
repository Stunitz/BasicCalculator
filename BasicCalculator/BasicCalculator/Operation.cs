using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    /// <summary>
    /// Holds information about a single calculator operation
    /// </summary>
    public class Operation
    {
        #region Public Properties

        /// <summary>
        /// The left side of the operation
        /// </summary>
        public string LeftSide { get; set; }

        /// <summary>
        /// The right side of the operation
        /// </summary>
        public string RightSide { get; set; }

        /// <summary>
        /// The type of operation to perform
        /// </summary>
        public OperationType OperationType { get; set; }

        /// <summary>
        /// The inner operation to be performed initialy before this operation
        /// </summary>
        public Operation InnerOperation { get; set; }

        #endregion

        #region Constructor

        public Operation()
        {
            // Create empty strings instead of having nulls
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;
        }

        #endregion
    }
}
