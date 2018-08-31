using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// EmailDocument
    /// </summary>
    public sealed partial class EmailDocument : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _docId;
        /// <summary>
        /// EmailDocument DocId
        /// </summary>
        public string DocId { get => _docId; set => _docId = value; }
        private DirtyValue<string> _docTitle;
        /// <summary>
        /// EmailDocument DocTitle
        /// </summary>
        public string DocTitle { get => _docTitle; set => _docTitle = value; }
        internal override bool DirtyInternal
        {
            get => _docId.Dirty
                || _docTitle.Dirty;
            set
            {
                _docId.Dirty = value;
                _docTitle.Dirty = value;
            }
        }
    }
}