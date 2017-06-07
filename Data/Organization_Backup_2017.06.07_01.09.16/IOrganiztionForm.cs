using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Organization
{
    public interface IOrganiztionForm
    {
        void addUnit(string Name, int parentId);
        void addMember(string UserId, int organizationId);
    }
}
