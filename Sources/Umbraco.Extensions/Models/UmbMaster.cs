﻿//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Zbu.ModelsBuilder v2.1.5.54
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Zbu.ModelsBuilder;
using Zbu.ModelsBuilder.Umbraco;

namespace Umbraco.Extensions.Models
{
    using Our.Umbraco.Vorto.Extensions;

    using Umbraco.Core;

    public partial class UmbMaster
    {
        /// <summary>
        /// Gets the url segment.
        /// </summary>
        [ImplementPropertyType("urlSegment")]
        public string UrlSegment
        {
            get
            {
                var urlSegment = this.GetVortoValue<string>("urlSegment");

                if (string.IsNullOrEmpty(urlSegment))
                {
                    urlSegment = this.UrlName;
                }

                return urlSegment.ToUrlSegment().EnsureEndsWith("/");
            }
        }

        /// <summary>
        /// Gets the url segment for a specific culture.
        /// </summary>
        /// <param name="culture"></param>
        /// <returns></returns>
        public string GetUrlSegment(string culture)
        {
            var urlSegment = this.GetVortoValue<string>("urlSegment", culture);

            if (string.IsNullOrEmpty(urlSegment))
            {
                urlSegment = this.UrlName;
            }

            return urlSegment.ToUrlSegment().EnsureEndsWith("/");
        }
    }
}