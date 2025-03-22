using System.Collections.Generic;
using LibraryManager.Models;

namespace LibraryManager.Interfaces
{
    public interface IMemberService
    {
        void AddMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int memberId);
        List<Member> GetAllMembers();
        Member GetMemberById(int memberId);
    }
}