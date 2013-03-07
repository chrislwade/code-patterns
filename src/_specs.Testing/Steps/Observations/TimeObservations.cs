#region FreeBSD

// Copyright (c) 2013, John Batte
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//  * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
// 
//  * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the
//    documentation and/or other materials provided with the distribution.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED
// TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR
// CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
// PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
// LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

#endregion

using System;

using Patterns.Testing.SpecFlow;

using TechTalk.SpecFlow;

namespace Patterns.Specifications.Steps.Observations
{
	public class TimeObservations
	{
		private static readonly string _systemDateTimeKey = ScenarioContext.Current.NewKey();
		private static readonly string _customDateTimeKey = ScenarioContext.Current.NewKey();
		private static readonly string _dateTimeDeltaKey = ScenarioContext.Current.NewKey();

		public static TimeSpan DateTimeDelta
		{
			get { return ScenarioContext.Current.GetValue<TimeSpan>(_dateTimeDeltaKey); }
			set { ScenarioContext.Current[_dateTimeDeltaKey] = value; }
		}

		public static DateTime SecondaryDateTime
		{
			get { return ScenarioContext.Current.GetValue<DateTime>(_systemDateTimeKey); }
			set { ScenarioContext.Current[_systemDateTimeKey] = value; }
		}

		public static DateTime PrimaryDateTime
		{
			get { return ScenarioContext.Current.GetValue<DateTime>(_customDateTimeKey); }
			set { ScenarioContext.Current[_customDateTimeKey] = value; }
		}
	}
}