﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.DynamicModules.Model;
using Telerik.Sitefinity.GenericContent.Model;
using Telerik.Sitefinity.Libraries.Model;
using Telerik.Sitefinity.Model;

namespace Telerik.Sitefinity.DynamicModules.StrongTypes
{
    public class DynamicTypeBase
    {
        protected internal DynamicContent DynamicContent { get; private set; }

        internal DynamicTypeBase()
        {
        }

        internal void Initialize(DynamicContent dynamicContent)
        {
            this.DynamicContent = dynamicContent;
        }

        protected T GetDynamicFieldValue<T>(string fieldName)
        {
            return this.DynamicContent.GetValue<T>(fieldName);
        }

        protected void SetDynamicFieldValue(string fieldName, object fieldValue)
        {
            this.DynamicContent.SetValue(fieldName, fieldValue);
        }

        protected void AddClassificationValue(string fieldName, params Guid[] taxonId)
        {
            this.DynamicContent.Organizer.AddTaxa(fieldName, taxonId);
        }

        protected void ClearClassificationField(string fieldName)
        {
            this.DynamicContent.Organizer.Clear(fieldName);
        }

        protected void AddImageValue(string fieldName, Guid imageId, string librariesProviderName = "")
        {
            this.DynamicContent.AddImage(fieldName, imageId, librariesProviderName);
        }

        protected void AddImageValue(string fieldName, Image image)
        {
            this.DynamicContent.AddImage(fieldName, image);
        }

        protected void ClearImages(string fieldName)
        {
            this.DynamicContent.ClearImages(fieldName);
        }

        protected void AddVideoValue(string fieldName, Guid videoId, string librariesProviderName = "")
        {
            this.DynamicContent.AddVideo(fieldName, videoId, librariesProviderName);
        }

        protected void AddVideoValue(string fieldName, Video video)
        {
            this.DynamicContent.AddVideo(fieldName, video);
        }

        protected void ClearVideos(string fieldName)
        {
            this.DynamicContent.ClearVideos(fieldName);
        }

        protected void AddFileValue(string fieldName, Guid fileId, string librariesProviderName = "")
        {
            this.DynamicContent.AddFile(fieldName, fileId, librariesProviderName);
        }

        protected void AddFileValue(string fieldName, Document file)
        {
            this.DynamicContent.AddFile(fieldName, file);
        }

        protected void ClearFiles(string fieldName)
        {
            this.DynamicContent.ClearFiles(fieldName);
        }

        public Guid Id
        {
            get
            {
                return this.DynamicContent.Id;
            }
        }

        public Guid SystemParentId
        {
            get
            {
                return this.DynamicContent.SystemParentId;
            }
        }

        public string SystemParentType
        {
            get
            {
                return this.DynamicContent.SystemParentType;
            }
        }

        public Lstring UrlName
        {
            get
            {
                return this.DynamicContent.UrlName;
            }
            set
            {
                this.DynamicContent.SetString("UrlName", value);
            }
        }

        public bool Visible
        {
            get
            {
                return this.DynamicContent.Visible;
            }
        }

        public string SystemUrl
        {
            get
            {
                return this.DynamicContent.SystemUrl;
            }
        }

        public ContentLifecycleStatus Status
        {
            get
            {
                return this.DynamicContent.Status;
            }
        }

        public DateTime PublicationDate
        {
            get
            {
                return this.DynamicContent.PublicationDate;
            }
        }

        public DateTime DateCreated
        {
            get
            {
                return this.DynamicContent.DateCreated;
            }
        }

        public Lstring ApprovalWorkflowState
        {
            get
            {
                return this.DynamicContent.ApprovalWorkflowState;
            }
        }

        public string Author
        {
            get
            {
                return this.DynamicContent.Author;
            }
        }

        public DateTime LastModified
        {
            get
            {
                return this.DynamicContent.LastModified;
            }
        }

        public Guid LastModifiedBy
        {
            get
            {
                return this.DynamicContent.LastModifiedBy;
            }
        }

        public Guid OriginalContentId
        {
            get
            {
                return this.DynamicContent.OriginalContentId;
            }
        }
    }
}