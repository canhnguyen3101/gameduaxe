//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.CloudSave.Internal.Http;



namespace Unity.Services.CloudSave.Internal.Models
{
    /// <summary>
    /// A human-readable explanation specific to this occurrence of the problem.
    /// </summary>
    [Preserve]
    [DataContract(Name = "DeleteConflictErrorResponse_allOf_data")]
    internal class DeleteConflictErrorResponseAllOfData
    {
        /// <summary>
        /// A human-readable explanation specific to this occurrence of the problem.
        /// </summary>
        /// <param name="key">key param</param>
        /// <param name="attemptedWriteLock">attemptedWriteLock param</param>
        /// <param name="existingWriteLock">existingWriteLock param</param>
        [Preserve]
        public DeleteConflictErrorResponseAllOfData(string key = default, string attemptedWriteLock = default, string existingWriteLock = default)
        {
            Key = key;
            AttemptedWriteLock = attemptedWriteLock;
            ExistingWriteLock = existingWriteLock;
        }

        /// <summary>
        /// Parameter key of DeleteConflictErrorResponseAllOfData
        /// </summary>
        [Preserve]
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key{ get; }
        
        /// <summary>
        /// Parameter attemptedWriteLock of DeleteConflictErrorResponseAllOfData
        /// </summary>
        [Preserve]
        [DataMember(Name = "attemptedWriteLock", EmitDefaultValue = false)]
        public string AttemptedWriteLock{ get; }
        
        /// <summary>
        /// Parameter existingWriteLock of DeleteConflictErrorResponseAllOfData
        /// </summary>
        [Preserve]
        [DataMember(Name = "existingWriteLock", EmitDefaultValue = false)]
        public string ExistingWriteLock{ get; }
    
        /// <summary>
        /// Formats a DeleteConflictErrorResponseAllOfData into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Key != null)
            {
                serializedModel += "key," + Key + ",";
            }
            if (AttemptedWriteLock != null)
            {
                serializedModel += "attemptedWriteLock," + AttemptedWriteLock + ",";
            }
            if (ExistingWriteLock != null)
            {
                serializedModel += "existingWriteLock," + ExistingWriteLock;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a DeleteConflictErrorResponseAllOfData as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Key != null)
            {
                var keyStringValue = Key.ToString();
                dictionary.Add("key", keyStringValue);
            }
            
            if (AttemptedWriteLock != null)
            {
                var attemptedWriteLockStringValue = AttemptedWriteLock.ToString();
                dictionary.Add("attemptedWriteLock", attemptedWriteLockStringValue);
            }
            
            if (ExistingWriteLock != null)
            {
                var existingWriteLockStringValue = ExistingWriteLock.ToString();
                dictionary.Add("existingWriteLock", existingWriteLockStringValue);
            }
            
            return dictionary;
        }
    }
}
