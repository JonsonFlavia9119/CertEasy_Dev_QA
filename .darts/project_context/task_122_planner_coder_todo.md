# Planner-Coder Todo — 122
**Requirement:** On Navigating to Admin/ManageEducation page I'm getting the below error
 Administrative Error
An unexpected error occurred in the administrative area. Invalid column name 'InstituteName'.

If this issue persists, please check the system logs or contact technical support.

Find the root cause and Add migration for this issue and fix this.
Note: If the column is already exists in the SQL table do not create

---

## Wiring Manifest

### Existing (preserve every line when modifying these files)
- CertEasy.Data/CertEasyDbContext.cs: All existing entity configurations and DbSets
- CertEasy.Web/Controllers/AdminController.cs: All actions and routing
- CertEasy.Services/AdminService.cs: All education and admin service operations

### Planned (add exactly these in STEP 3 — decided now, not during coding)
- CertEasy.Data/Migrations/20260921115811_AddInstituteNameToEducation.cs: Add migration checking if InstituteName column exists in Educations table and adding it if missing
- CertEasy.Data/Migrations/20260921115811_AddInstituteNameToEducation.Designer.cs: Add migration metadata designer file

---

## All Tasks

| ID | Task | Files | Status | Depends On |
|---|---|---|---|---|
| T-001 | Backend — Add migration for InstituteName column on Educations table | CertEasy.Data/Migrations/20260921115811_AddInstituteNameToEducation.cs, CertEasy.Data/Migrations/20260921115811_AddInstituteNameToEducation.Designer.cs | pending | — |
