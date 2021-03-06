/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeInstanceStatisticsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeInstanceStatistics_Entity> data;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<DescribeInstanceStatistics_Entity> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeInstanceStatistics_Entity
		{

			private string uuid;

			private int? account;

			private int? health;

			private int? trojan;

			private int? suspicious;

			private int? vul;

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public int? Account
			{
				get
				{
					return account;
				}
				set	
				{
					account = value;
				}
			}

			public int? Health
			{
				get
				{
					return health;
				}
				set	
				{
					health = value;
				}
			}

			public int? Trojan
			{
				get
				{
					return trojan;
				}
				set	
				{
					trojan = value;
				}
			}

			public int? Suspicious
			{
				get
				{
					return suspicious;
				}
				set	
				{
					suspicious = value;
				}
			}

			public int? Vul
			{
				get
				{
					return vul;
				}
				set	
				{
					vul = value;
				}
			}
		}
	}
}
