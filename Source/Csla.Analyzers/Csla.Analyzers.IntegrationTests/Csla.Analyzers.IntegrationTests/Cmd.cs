﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla;
using Csla.Serialization;

namespace ProjectTracker.Library
{
  // This should fail because it doesn't have a no-arg ctor
  [Serializable]
  public class ResourceExistsCommand : CommandBase<ResourceExistsCommand>
  {
    public ResourceExistsCommand(int id)
    {
      ResourceId = id;
    }

    public static PropertyInfo<int> ResourceIdProperty = RegisterProperty<int>(c => c.ResourceId);
    public int ResourceId
    {
      get { return ReadProperty(ResourceIdProperty); }
      private set { LoadProperty(ResourceIdProperty, value); }
    }

    public static PropertyInfo<bool> ResourceExistsProperty = RegisterProperty<bool>(c => c.ResourceExists);
    public bool ResourceExists
    {
      get { return ReadProperty(ResourceExistsProperty); }
      private set { LoadProperty(ResourceExistsProperty, value); }
    }

#if !NETFX_CORE
    protected override void DataPortal_Execute()
    {
    }
#endif
  }
}