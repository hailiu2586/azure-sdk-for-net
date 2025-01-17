// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The recurrence schedule. </summary>
    public partial class RecurrenceSchedule : IDictionary<string, object>
    {
        /// <summary> Initializes a new instance of RecurrenceSchedule. </summary>
        public RecurrenceSchedule()
        {
            Minutes = new ChangeTrackingList<int>();
            Hours = new ChangeTrackingList<int>();
            WeekDays = new ChangeTrackingList<DaysOfWeek>();
            MonthDays = new ChangeTrackingList<int>();
            MonthlyOccurrences = new ChangeTrackingList<RecurrenceScheduleOccurrence>();
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of RecurrenceSchedule. </summary>
        /// <param name="minutes"> The minutes. </param>
        /// <param name="hours"> The hours. </param>
        /// <param name="weekDays"> The days of the week. </param>
        /// <param name="monthDays"> The month days. </param>
        /// <param name="monthlyOccurrences"> The monthly occurrences. </param>
        /// <param name="additionalProperties"> . </param>
        internal RecurrenceSchedule(IList<int> minutes, IList<int> hours, IList<DaysOfWeek> weekDays, IList<int> monthDays, IList<RecurrenceScheduleOccurrence> monthlyOccurrences, IDictionary<string, object> additionalProperties)
        {
            Minutes = minutes;
            Hours = hours;
            WeekDays = weekDays;
            MonthDays = monthDays;
            MonthlyOccurrences = monthlyOccurrences;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The minutes. </summary>
        public IList<int> Minutes { get; }
        /// <summary> The hours. </summary>
        public IList<int> Hours { get; }
        /// <summary> The days of the week. </summary>
        public IList<DaysOfWeek> WeekDays { get; }
        /// <summary> The month days. </summary>
        public IList<int> MonthDays { get; }
        /// <summary> The monthly occurrences. </summary>
        public IList<RecurrenceScheduleOccurrence> MonthlyOccurrences { get; }
        internal IDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public ICollection<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public ICollection<object> Values => AdditionalProperties.Values;
        /// <inheritdoc cref="ICollection{T}.Count"/>
        int ICollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public void Add(string key, object value) => AdditionalProperties.Add(key, value);
        /// <inheritdoc />
        public bool Remove(string key) => AdditionalProperties.Remove(key);
        /// <inheritdoc cref="ICollection{T}.IsReadOnly"/>
        bool ICollection<KeyValuePair<string, object>>.IsReadOnly => AdditionalProperties.IsReadOnly;
        /// <inheritdoc cref="ICollection{T}.Add"/>
        void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> value) => AdditionalProperties.Add(value);
        /// <inheritdoc cref="ICollection{T}.Remove"/>
        bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> value) => AdditionalProperties.Remove(value);
        /// <inheritdoc cref="ICollection{T}.Contains"/>
        bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> value) => AdditionalProperties.Contains(value);
        /// <inheritdoc cref="ICollection{T}.CopyTo"/>
        void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] destination, int offset) => AdditionalProperties.CopyTo(destination, offset);
        /// <inheritdoc cref="ICollection{T}.Clear"/>
        void ICollection<KeyValuePair<string, object>>.Clear() => AdditionalProperties.Clear();
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
            set => AdditionalProperties[key] = value;
        }
    }
}
