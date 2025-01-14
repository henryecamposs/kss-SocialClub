﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Validation
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class RegexAttribute : ValidationAttribute
    {
        public string Pattern { get; set; }
        public RegexOptions Options { get; set; }

        public RegexAttribute(string pattern, RegexOptions options = RegexOptions.None)
        {
            Pattern = pattern;
            Options = options;
        }

        public override bool IsValid(object value)
        {
            return IsValid(value as string);
        }

        public bool IsValid(string value)
        {
            return string.IsNullOrEmpty(value) ? true : new Regex(Pattern, Options).IsMatch(value);
        }
    }
}
