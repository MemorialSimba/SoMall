﻿using System;
using System.Diagnostics.CodeAnalysis;
using Volo.Abp.Domain.Entities.Auditing;

namespace TT.Abp.VisitorManagement.Domain
{
    public class FormItem : CreationAuditedEntity
    {
        public FormItem(Guid fromId, Guid itemId)
        {
            ItemId = itemId;
            FromId = fromId;
        }

        public Guid FromId { get; }
        public Guid ItemId { get; }

        public VisitorEnums.FormItemType Type { get; set; }

        public int Sort { get; set; }

        [NotNull] public string Label { get; set; }
        [NotNull] public string Key { get; set; }

        [NotNull] public string PlaceHolder { get; set; }

        public string DefaultValue { get; set; }
        public string ErrorText { get; set; }

        public bool IsRequired { get; set; }
        public bool IsDisable { get; set; }

        public bool IsMulti { get; set; }

        public string SelectionJson { get; set; }

        public override object[] GetKeys()
        {
            return new object[] {FromId, ItemId};
        }
    }
}