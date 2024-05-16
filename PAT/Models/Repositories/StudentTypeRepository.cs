﻿using MauiSqlite;
using PAT.Models.Entities;
using PAT.Models.Repositories.Interfaces;

namespace PAT.Models.Repositories;

/// <summary>
/// Provides data-access to Student Types.
/// </summary>
public class StudentTypeRepository : Repository<StudentType>, IStudentTypeRepository
{
    private AppDbContext _context;
    protected StudentTypeRepository(AppDbContext context) 
        : base(context)
    {
        _context = context;
    }
}