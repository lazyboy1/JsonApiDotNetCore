using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Resources;
using Xunit;

namespace UnitTests.Graph
{
    public sealed class ResourceDescriptorAssemblyCacheTests
    {
        [Fact]
        public void GetResourceDescriptorsPerAssembly_Locates_Identifiable_Resource()
        {
            // Arrange
            Type resourceType = typeof(Model);

            var assemblyCache = new ResourceDescriptorAssemblyCache();
            assemblyCache.RegisterAssembly(resourceType.Assembly);

            // Act
            IReadOnlyCollection<ResourceDescriptor> descriptors = assemblyCache.GetResourceDescriptors();

            // Assert
            descriptors.Should().NotBeEmpty();
            descriptors.Should().ContainSingle(descriptor => descriptor.ResourceType == resourceType);
        }

        [Fact]
        public void GetResourceDescriptorsPerAssembly_Only_Contains_IIdentifiable_Types()
        {
            // Arrange
            Type resourceType = typeof(Model);

            var assemblyCache = new ResourceDescriptorAssemblyCache();
            assemblyCache.RegisterAssembly(resourceType.Assembly);

            // Act
            IReadOnlyCollection<ResourceDescriptor> descriptors = assemblyCache.GetResourceDescriptors();

            // Assert
            descriptors.Should().NotBeEmpty();
            descriptors.Select(descriptor => descriptor.ResourceType).Should().AllBeAssignableTo<IIdentifiable>();
        }
    }
}
