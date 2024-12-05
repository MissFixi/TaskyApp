using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskyAPI.Repositories;

namespace Tasky.Objects;
public class Employee
{
    private int idEmployee;
    private Boolean isManager;

    public Employee(int idEmployee)
    {
        this.idEmployee = idEmployee;
        isManager = false;
    }

    public async Task<bool> IsMgr(UserRepository userRepository)
    {
        isManager = await userRepository.IsUserManagerAsync(this.idEmployee);
        return isManager;
    }

    public int getId()
    {
        return idEmployee;
    }

}
    
    

