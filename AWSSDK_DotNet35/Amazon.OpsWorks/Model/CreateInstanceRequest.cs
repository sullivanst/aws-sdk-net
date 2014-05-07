/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInstance operation.
    /// <para>Creates an instance in a specified stack. For more information, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-add.html" >Adding an Instance to a Layer</a> .</para> <para>
    /// <b>Required Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that
    /// explicitly grants permissions. For more information on user permissions, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
    /// </summary>
    public partial class CreateInstanceRequest : AmazonOpsWorksRequest
    {
        private string stackId;
        private List<string> layerIds = new List<string>();
        private string instanceType;
        private AutoScalingType autoScalingType;
        private string hostname;
        private string os;
        private string amiId;
        private string sshKeyName;
        private string availabilityZone;
        private string subnetId;
        private Architecture architecture;
        private RootDeviceType rootDeviceType;
        private bool? installUpdatesOnBoot;
        private bool? ebsOptimized;


        /// <summary>
        /// The stack ID.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

        /// <summary>
        /// An array that contains the instance layer IDs.
        ///  
        /// </summary>
        public List<string> LayerIds
        {
            get { return this.layerIds; }
            set { this.layerIds = value; }
        }

        // Check to see if LayerIds property is set
        internal bool IsSetLayerIds()
        {
            return this.layerIds.Count > 0;
        }

        /// <summary>
        /// The instance type. AWS OpsWorks supports all instance types except Cluster Compute, Cluster GPU, and High Memory Cluster. For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance Families and Types</a>. The
        /// parameter values that you use to specify the various types are in the API Name column of the Available Instance Types table.
        ///  
        /// </summary>
        public string InstanceType
        {
            get { return this.instanceType; }
            set { this.instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this.instanceType != null;
        }

        /// <summary>
        /// The instance auto scaling type, which has three possible values: <ul> <li><b>AlwaysRunning</b>: A 24/7 instance, which is not affected by
        /// auto scaling.</li> <li><b>TimeBasedAutoScaling</b>: A time-based auto scaling instance, which is started and stopped based on a specified
        /// schedule. To specify the schedule, call <a>SetTimeBasedAutoScaling</a>.</li> <li><b>LoadBasedAutoScaling</b>: A load-based auto scaling
        /// instance, which is started and stopped based on load metrics. To use load-based auto scaling, you must enable it for the instance layer and
        /// configure the thresholds by calling <a>SetLoadBasedAutoScaling</a>.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>load, timer</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public AutoScalingType AutoScalingType
        {
            get { return this.autoScalingType; }
            set { this.autoScalingType = value; }
        }

        // Check to see if AutoScalingType property is set
        internal bool IsSetAutoScalingType()
        {
            return this.autoScalingType != null;
        }

        /// <summary>
        /// The instance host name.
        ///  
        /// </summary>
        public string Hostname
        {
            get { return this.hostname; }
            set { this.hostname = value; }
        }

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this.hostname != null;
        }

        /// <summary>
        /// The instance operating system, which must be set to one of the following. <ul> <li>Standard operating systems: <c>Amazon Linux</c> or
        /// <c>Ubuntu 12.04 LTS</c></li> <li>Custom AMIs: <c>Custom</c></li> </ul> The default option is <c>Amazon Linux</c>. If you set this parameter
        /// to <c>Custom</c>, you must use the <a>CreateInstance</a> action's AmiId parameter to specify the custom AMI that you want to use. For more
        /// information on the standard operating systems, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-os.html">Operating Systems</a>For more information on how to use
        /// custom AMIs with OpsWorks, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-custom-ami.html">Using Custom
        /// AMIs</a>.
        ///  
        /// </summary>
        public string Os
        {
            get { return this.os; }
            set { this.os = value; }
        }

        // Check to see if Os property is set
        internal bool IsSetOs()
        {
            return this.os != null;
        }

        /// <summary>
        /// A custom AMI ID to be used to create the instance. The AMI should be based on one of the standard AWS OpsWorks APIs: Amazon Linux or Ubuntu
        /// 12.04 LTS. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances.html">Instances</a>
        ///  
        /// </summary>
        public string AmiId
        {
            get { return this.amiId; }
            set { this.amiId = value; }
        }

        // Check to see if AmiId property is set
        internal bool IsSetAmiId()
        {
            return this.amiId != null;
        }

        /// <summary>
        /// The instance SSH key name.
        ///  
        /// </summary>
        public string SshKeyName
        {
            get { return this.sshKeyName; }
            set { this.sshKeyName = value; }
        }

        // Check to see if SshKeyName property is set
        internal bool IsSetSshKeyName()
        {
            return this.sshKeyName != null;
        }

        /// <summary>
        /// The instance Availability Zone. For more information, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions and
        /// Endpoints</a>.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// The ID of the instance's subnet. If the stack is running in a VPC, you can use this parameter to override the stack's default subnet ID
        /// value and direct AWS OpsWorks to launch the instance in a different subnet.
        ///  
        /// </summary>
        public string SubnetId
        {
            get { return this.subnetId; }
            set { this.subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this.subnetId != null;
        }

        /// <summary>
        /// The instance architecture. The default option is <c>x86_64</c>. Instance types do not necessarily support both architectures. For a list of
        /// the architectures that are supported by the different instance types, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance Families and Types</a>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>x86_64, i386</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public Architecture Architecture
        {
            get { return this.architecture; }
            set { this.architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this.architecture != null;
        }

        /// <summary>
        /// The instance root device type. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ComponentsAMIs.html#storage-for-the-root-device">Storage for the Root Device</a>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ebs, instance-store</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public RootDeviceType RootDeviceType
        {
            get { return this.rootDeviceType; }
            set { this.rootDeviceType = value; }
        }

        // Check to see if RootDeviceType property is set
        internal bool IsSetRootDeviceType()
        {
            return this.rootDeviceType != null;
        }

        /// <summary>
        /// Whether to install operating system and package updates when the instance boots. The default value is <c>true</c>. To control when updates
        /// are installed, set this value to <c>false</c>. You must then update your instances manually by using <a>CreateDeployment</a> to run the
        /// <c>update_dependencies</c> stack command or manually running <c>yum</c> (Amazon Linux) or <c>apt-get</c> (Ubuntu) on the instances. <note>
        /// We strongly recommend using the default value of <c>true</c> to ensure that your instances have the latest security updates. </note>
        ///  
        /// </summary>
        public bool InstallUpdatesOnBoot
        {
            get { return this.installUpdatesOnBoot ?? default(bool); }
            set { this.installUpdatesOnBoot = value; }
        }

        // Check to see if InstallUpdatesOnBoot property is set
        internal bool IsSetInstallUpdatesOnBoot()
        {
            return this.installUpdatesOnBoot.HasValue;
        }

        /// <summary>
        /// Whether to create an Amazon EBS-optimized instance.
        ///  
        /// </summary>
        public bool EbsOptimized
        {
            get { return this.ebsOptimized ?? default(bool); }
            set { this.ebsOptimized = value; }
        }

        // Check to see if EbsOptimized property is set
        internal bool IsSetEbsOptimized()
        {
            return this.ebsOptimized.HasValue;
        }

    }
}
    