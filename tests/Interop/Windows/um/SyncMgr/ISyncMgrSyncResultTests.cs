// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ISyncMgrSyncResult" /> struct.</summary>
    public static unsafe partial class ISyncMgrSyncResultTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISyncMgrSyncResult" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ISyncMgrSyncResult).GUID, Is.EqualTo(IID_ISyncMgrSyncResult));
        }

        /// <summary>Validates that the <see cref="ISyncMgrSyncResult" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ISyncMgrSyncResult>(), Is.EqualTo(sizeof(ISyncMgrSyncResult)));
        }

        /// <summary>Validates that the <see cref="ISyncMgrSyncResult" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ISyncMgrSyncResult).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ISyncMgrSyncResult" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ISyncMgrSyncResult), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ISyncMgrSyncResult), Is.EqualTo(4));
            }
        }
    }
}
