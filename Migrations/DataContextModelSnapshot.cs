﻿// <auto-generated />
using System;
using ExamEdu.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ExamEdu.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            modelBuilder.Entity("ExamEdu.DB.Models.AcademicDepartment", b =>
                {
                    b.Property<int>("AcademicDepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeactivatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("AcademicDepartmentId");

                    b.HasIndex("RoleId");

                    b.ToTable("AcademicDepartments");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.AddQuestionRequest", b =>
                {
                    b.Property<int>("AddQuestionRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("ApproverId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("RequesterId")
                        .HasColumnType("integer");

                    b.HasKey("AddQuestionRequestId");

                    b.HasIndex("ApproverId");

                    b.HasIndex("RequesterId");

                    b.ToTable("AddQuestionRequests");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Administrator", b =>
                {
                    b.Property<int>("AdministratorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Fullname")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("AdministratorId");

                    b.HasIndex("RoleId");

                    b.ToTable("Administrators");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("AnswerContent")
                        .HasColumnType("text");

                    b.Property<int>("QuestionId")
                        .HasColumnType("integer");

                    b.Property<bool>("isCorrect")
                        .HasColumnType("boolean");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("ClassName")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeactivatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("EndDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeactivated")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("StartDay")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ClassId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.ClassModule", b =>
                {
                    b.Property<int>("ClassModuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("ClassId")
                        .HasColumnType("integer");

                    b.Property<int>("ModuleId")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer");

                    b.HasKey("ClassModuleId");

                    b.HasIndex("ModuleId");

                    b.HasIndex("TeacherId");

                    b.HasIndex("ClassId", "ModuleId")
                        .IsUnique();

                    b.ToTable("ClassModules");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Class_Module_Student", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.Property<int>("ClassModuleId")
                        .HasColumnType("integer");

                    b.HasKey("StudentId", "ClassModuleId");

                    b.HasIndex("ClassModuleId");

                    b.ToTable("Class_Module_Students");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Exam", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("DurationInMinute")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ExamDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ExamName")
                        .HasColumnType("text");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("boolean");

                    b.Property<int>("ModuleId")
                        .HasColumnType("integer");

                    b.Property<int>("ProctorId")
                        .HasColumnType("integer");

                    b.Property<int>("SupervisorId")
                        .HasColumnType("integer");

                    b.Property<bool>("isFinalExam")
                        .HasColumnType("boolean");

                    b.HasKey("ExamId");

                    b.HasIndex("ExamName")
                        .IsUnique();

                    b.HasIndex("ModuleId");

                    b.HasIndex("ProctorId");

                    b.HasIndex("SupervisorId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.ExamQuestion", b =>
                {
                    b.Property<int>("ExamQuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("ExamCode")
                        .HasColumnType("integer");

                    b.Property<int>("ExamId")
                        .HasColumnType("integer");

                    b.Property<int>("QuestionId")
                        .HasColumnType("integer");

                    b.Property<float>("QuestionMark")
                        .HasColumnType("real");

                    b.HasKey("ExamQuestionId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("ExamId", "QuestionId", "ExamCode")
                        .IsUnique();

                    b.ToTable("ExamQuestions");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Exam_FEQuestion", b =>
                {
                    b.Property<int>("ExamFEQuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("ExamCode")
                        .HasColumnType("integer");

                    b.Property<int>("ExamId")
                        .HasColumnType("integer");

                    b.Property<int>("FEQuestionId")
                        .HasColumnType("integer");

                    b.Property<float>("QuestionMark")
                        .HasColumnType("real");

                    b.HasKey("ExamFEQuestionId");

                    b.HasIndex("FEQuestionId");

                    b.HasIndex("ExamId", "FEQuestionId", "ExamCode")
                        .IsUnique();

                    b.ToTable("Exam_FEQuestions");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.FEAnswer", b =>
                {
                    b.Property<int>("FEAnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("AnswerContent")
                        .HasColumnType("text");

                    b.Property<int>("FEQuestionId")
                        .HasColumnType("integer");

                    b.Property<bool>("isCorrect")
                        .HasColumnType("boolean");

                    b.HasKey("FEAnswerId");

                    b.HasIndex("FEQuestionId");

                    b.ToTable("FEAnswers");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.FEQuestion", b =>
                {
                    b.Property<int>("FEQuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("AddQuestionRequestId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("ApproveAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("LevelId")
                        .HasColumnType("integer");

                    b.Property<int>("ModuleId")
                        .HasColumnType("integer");

                    b.Property<string>("QuestionContent")
                        .HasColumnType("text");

                    b.Property<string>("QuestionImageURL")
                        .HasColumnType("text");

                    b.Property<int>("QuestionTypeId")
                        .HasColumnType("integer");

                    b.Property<bool>("isApproved")
                        .HasColumnType("boolean");

                    b.HasKey("FEQuestionId");

                    b.HasIndex("AddQuestionRequestId");

                    b.HasIndex("LevelId");

                    b.HasIndex("ModuleId");

                    b.HasIndex("QuestionTypeId");

                    b.ToTable("FEQuestions");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Level", b =>
                {
                    b.Property<int>("LevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("LevelName")
                        .HasColumnType("text");

                    b.HasKey("LevelId");

                    b.ToTable("Levels");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Module", b =>
                {
                    b.Property<int>("ModuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ModuleName")
                        .HasColumnType("text");

                    b.HasKey("ModuleId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("AddQuestionRequestId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("ApproveAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<int>("LevelId")
                        .HasColumnType("integer");

                    b.Property<int>("ModuleId")
                        .HasColumnType("integer");

                    b.Property<string>("QuestionContent")
                        .HasColumnType("text");

                    b.Property<string>("QuestionImageURL")
                        .HasColumnType("text");

                    b.Property<int>("QuestionTypeId")
                        .HasColumnType("integer");

                    b.HasKey("QuestionId");

                    b.HasIndex("AddQuestionRequestId");

                    b.HasIndex("LevelId");

                    b.HasIndex("ModuleId");

                    b.HasIndex("QuestionTypeId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.QuestionType", b =>
                {
                    b.Property<int>("QuestionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("QuestionTypeName")
                        .HasColumnType("text");

                    b.HasKey("QuestionTypeId");

                    b.ToTable("QuestionTypes");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("RoleName")
                        .HasColumnType("text");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeactivatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Fullname")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("StudentId");

                    b.HasIndex("RoleId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.StudentAnswer", b =>
                {
                    b.Property<int>("StudentAnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("ExamQuestionId")
                        .HasColumnType("integer");

                    b.Property<string>("StudentAnswerContent")
                        .HasColumnType("text");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("StudentAnswerId");

                    b.HasIndex("ExamQuestionId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentAnswers");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.StudentExamInfo", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.Property<int>("ExamId")
                        .HasColumnType("integer");

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<DateTime?>("FinishAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<float?>("Mark")
                        .HasColumnType("real");

                    b.HasKey("StudentId", "ExamId");

                    b.HasIndex("ExamId");

                    b.ToTable("StudentExamInfos");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.StudentFEAnswer", b =>
                {
                    b.Property<int>("StudentFEAnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("ExamFEQuestionId")
                        .HasColumnType("integer");

                    b.Property<string>("StudentAnswerContent")
                        .HasColumnType("text");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("StudentFEAnswerId");

                    b.HasIndex("ExamFEQuestionId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentFEAnswers");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeactivatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Fullname")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("TeacherId");

                    b.HasIndex("RoleId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.AcademicDepartment", b =>
                {
                    b.HasOne("ExamEdu.DB.Models.Role", "Role")
                        .WithMany("AcademicDepartments")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.AddQuestionRequest", b =>
                {
                    b.HasOne("ExamEdu.DB.Models.Teacher", "Approver")
                        .WithMany("AddQuestionApproves")
                        .HasForeignKey("ApproverId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("ExamEdu.DB.Models.Teacher", "Requester")
                        .WithMany("AddQuestionRequests")
                        .HasForeignKey("RequesterId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Approver");

                    b.Navigation("Requester");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Administrator", b =>
                {
                    b.HasOne("ExamEdu.DB.Models.Role", "Role")
                        .WithMany("Administrators")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Answer", b =>
                {
                    b.HasOne("ExamEdu.DB.Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.ClassModule", b =>
                {
                    b.HasOne("ExamEdu.DB.Models.Class", "Class")
                        .WithMany("ClassModules")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamEdu.DB.Models.Module", "Module")
                        .WithMany("ClassModules")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamEdu.DB.Models.Teacher", "Teacher")
                        .WithMany("ClassModules")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Module");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Class_Module_Student", b =>
                {
                    b.HasOne("ExamEdu.DB.Models.ClassModule", "ClassModule")
                        .WithMany("Class_Module_Students")
                        .HasForeignKey("ClassModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamEdu.DB.Models.Student", "Student")
                        .WithMany("Class_Module_Students")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassModule");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Exam", b =>
                {
                    b.HasOne("ExamEdu.DB.Models.Module", "Module")
                        .WithMany("Exams")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("ExamEdu.DB.Models.Teacher", "Proctor")
                        .WithMany("Exams")
                        .HasForeignKey("ProctorId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("ExamEdu.DB.Models.AcademicDepartment", "Supervisor")
                        .WithMany("Exams")
                        .HasForeignKey("SupervisorId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Module");

                    b.Navigation("Proctor");

                    b.Navigation("Supervisor");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.ExamQuestion", b =>
                {
                    b.HasOne("ExamEdu.DB.Models.Exam", "Exam")
                        .WithMany("ExamQuestions")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamEdu.DB.Models.Question", "Question")
                        .WithMany("ExamQuestions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Exam_FEQuestion", b =>
                {
                    b.HasOne("ExamEdu.DB.Models.Exam", "Exam")
                        .WithMany("Exam_FEQuestions")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamEdu.DB.Models.FEQuestion", "FEQuestion")
                        .WithMany("Exam_FEQuestions")
                        .HasForeignKey("FEQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("FEQuestion");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.FEAnswer", b =>
                {
                    b.HasOne("ExamEdu.DB.Models.FEQuestion", "FEQuestion")
                        .WithMany("FEAnswers")
                        .HasForeignKey("FEQuestionId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("FEQuestion");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.FEQuestion", b =>
                {
                    b.HasOne("ExamEdu.DB.Models.AddQuestionRequest", "AddQuestionRequest")
                        .WithMany("FEQuestions")
                        .HasForeignKey("AddQuestionRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamEdu.DB.Models.Level", "Level")
                        .WithMany("FEQuestions")
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("ExamEdu.DB.Models.Module", "Module")
                        .WithMany("FEQuestions")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("ExamEdu.DB.Models.QuestionType", "QuestionType")
                        .WithMany("FEQuestions")
                        .HasForeignKey("QuestionTypeId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("AddQuestionRequest");

                    b.Navigation("Level");

                    b.Navigation("Module");

                    b.Navigation("QuestionType");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Question", b =>
                {
                    b.HasOne("ExamEdu.DB.Models.AddQuestionRequest", "AddQuestionRequest")
                        .WithMany("Questions")
                        .HasForeignKey("AddQuestionRequestId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("ExamEdu.DB.Models.Level", "Level")
                        .WithMany("Questions")
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("ExamEdu.DB.Models.Module", "Module")
                        .WithMany("Questions")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("ExamEdu.DB.Models.QuestionType", "QuestionType")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionTypeId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("AddQuestionRequest");

                    b.Navigation("Level");

                    b.Navigation("Module");

                    b.Navigation("QuestionType");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Student", b =>
                {
                    b.HasOne("ExamEdu.DB.Models.Role", "Role")
                        .WithMany("Students")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.StudentAnswer", b =>
                {
                    b.HasOne("ExamEdu.DB.Models.ExamQuestion", "ExamQuestion")
                        .WithMany("StudentAnswers")
                        .HasForeignKey("ExamQuestionId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("ExamEdu.DB.Models.Student", "Student")
                        .WithMany("StudentAnswers")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("ExamQuestion");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.StudentExamInfo", b =>
                {
                    b.HasOne("ExamEdu.DB.Models.Exam", "Exam")
                        .WithMany("StudentExamInfos")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamEdu.DB.Models.Student", "Student")
                        .WithMany("StudentExamInfos")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.StudentFEAnswer", b =>
                {
                    b.HasOne("ExamEdu.DB.Models.Exam_FEQuestion", "Exam_FEQuestion")
                        .WithMany("StudentFEAnswers")
                        .HasForeignKey("ExamFEQuestionId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("ExamEdu.DB.Models.Student", "Student")
                        .WithMany("StudentFEAnswers")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Exam_FEQuestion");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Teacher", b =>
                {
                    b.HasOne("ExamEdu.DB.Models.Role", "Role")
                        .WithMany("Teachers")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.AcademicDepartment", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.AddQuestionRequest", b =>
                {
                    b.Navigation("FEQuestions");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Class", b =>
                {
                    b.Navigation("ClassModules");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.ClassModule", b =>
                {
                    b.Navigation("Class_Module_Students");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Exam", b =>
                {
                    b.Navigation("Exam_FEQuestions");

                    b.Navigation("ExamQuestions");

                    b.Navigation("StudentExamInfos");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.ExamQuestion", b =>
                {
                    b.Navigation("StudentAnswers");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Exam_FEQuestion", b =>
                {
                    b.Navigation("StudentFEAnswers");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.FEQuestion", b =>
                {
                    b.Navigation("Exam_FEQuestions");

                    b.Navigation("FEAnswers");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Level", b =>
                {
                    b.Navigation("FEQuestions");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Module", b =>
                {
                    b.Navigation("ClassModules");

                    b.Navigation("Exams");

                    b.Navigation("FEQuestions");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Question", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("ExamQuestions");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.QuestionType", b =>
                {
                    b.Navigation("FEQuestions");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Role", b =>
                {
                    b.Navigation("AcademicDepartments");

                    b.Navigation("Administrators");

                    b.Navigation("Students");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Student", b =>
                {
                    b.Navigation("Class_Module_Students");

                    b.Navigation("StudentAnswers");

                    b.Navigation("StudentExamInfos");

                    b.Navigation("StudentFEAnswers");
                });

            modelBuilder.Entity("ExamEdu.DB.Models.Teacher", b =>
                {
                    b.Navigation("AddQuestionApproves");

                    b.Navigation("AddQuestionRequests");

                    b.Navigation("ClassModules");

                    b.Navigation("Exams");
                });
#pragma warning restore 612, 618
        }
    }
}
