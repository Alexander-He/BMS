﻿using AutoMapper;
using BMS.AppData;
using BMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS
{
    public static class DataService
    {

        public static bool IsMetadataInUse(int Id, MetaDataType metaDataType)
        {
            using (BMSContext context = new BMSContext())
            {
                switch (metaDataType)
                {
                    case MetaDataType.Place:
                        return context.Projects.Any(x => x.Place == Id);
                    case MetaDataType.DesignUnit:
                        return context.Projects.Any(x => x.DesignUnit == Id);

                    case MetaDataType.ConstructUnit:
                        return context.Projects.Any(x => x.ConstructUnit == Id);

                    case MetaDataType.SupervisorUnit:
                        return context.Projects.Any(x => x.SupervisorUnit == Id);

                    case MetaDataType.ReportCondition:
                        return context.Projects.Any(x => x.ReportCondition == Id);

                    case MetaDataType.BuildStruct:
                        return context.Projects.Any(x => x.BuildStruct == Id);
                    default:
                        return false;
                }
            }
        }

        public static Project GetProject(string Id)
        {
            using (BMSContext context = new BMSContext())
            { 
                return context.Projects.FirstOrDefault(x => x.Id == Id);
            }
        }

        public static Project GetProjectByName(string name)
        {
            using (BMSContext context = new BMSContext())
            {
                return context.Projects.FirstOrDefault(x => x.ProjectName == name);
            }
        }

        public static Project GetProjectByCode(string code)
        {
            using (BMSContext context = new BMSContext())
            {
                return context.Projects.FirstOrDefault(x => x.Code == code);
            }
        }
        public static int AddProject(Project entity)
        {
            if (entity != null)
            {
                using (BMSContext context = new BMSContext())
                {
                    context.Projects.Add(entity);
                    return context.SaveChanges();
                }
            }
            return 0;
        }

        public static int UpdateProject(Project entity)
        {
            if (entity != null)
            {
                using (BMSContext context = new BMSContext())
                {
                    var dbEntity = context.Projects.FirstOrDefault(x => x.Id == entity.Id);
                    if (dbEntity != null)
                    {
                        dbEntity.ProjectName = entity.ProjectName;
                        dbEntity.Code = entity.Code;
                        dbEntity.Address = entity.Address;
                        dbEntity.Place = entity.Place;
                        dbEntity.BuildUnit = entity.BuildUnit;
                        dbEntity.ConstructUnit = entity.ConstructUnit;
                        dbEntity.DesignUnit = entity.DesignUnit;
                        dbEntity.BuildStruct = entity.BuildStruct;
                        dbEntity.ReportCondition = entity.ReportCondition;
                        dbEntity.SupervisorUnit = entity.SupervisorUnit;
                        dbEntity.WorkChargre = entity.WorkChargre;
                        dbEntity.Contact = entity.Contact;
                        dbEntity.ProjectDesc = entity.ProjectDesc;
                        dbEntity.ProjectProgress = entity.ProjectProgress;
                        dbEntity.WorkStartDate = entity.WorkStartDate;
                        dbEntity.CheckDate = entity.CheckDate;
                        dbEntity.BuildArea = entity.BuildArea;
                        dbEntity.InvestigateCase = entity.InvestigateCase;
                        dbEntity.Remark = entity.Remark;
                        return context.SaveChanges();
                    }
                }
            }
            return 0;
        }

        public static int DelProject(List<string> Ids)
        {
            using (BMSContext context = new BMSContext())
            {
                int result = 0;
                foreach (var Id in Ids)
                {
                    if (context.Projects.Any(x => x.Id == Id))
                    {
                        context.Projects.Remove(context.Projects.First(x => x.Id == Id));
                    }
                    result = context.SaveChanges();
                }
                return result;
            }
        }
        /// <summary>
        /// 查詢所有DicItem
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static List<PropertyMetadata> GetAllMetadata(MetaDataType type = MetaDataType.Place)
        {
            using (BMSContext context = new BMSContext())
            {
                var list = context.PropertyMetadatas.Where(x => x.Type == type.ToString()).ToList();
                return list;
            }
        }
        /// <summary>
        /// 查詢DicItem
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static PropertyMetadata GetMetadata(int Id)
        {
            using (BMSContext context = new BMSContext())
            {
                if (context.PropertyMetadatas.Any(x => x.Id == Id))
                {
                    return context.PropertyMetadatas.First(x => x.Id == Id);
                }
                return null;
            }
        }
        /// <summary>
        /// 查詢DicItem
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static PropertyMetadata GetMetadata(string name, MetaDataType type = MetaDataType.Place)
        {
            using (BMSContext context = new BMSContext())
            {
                if (context.PropertyMetadatas.Any(x => x.Name == name && x.Type == type.ToString()))
                {
                    return context.PropertyMetadatas.First(x => x.Name == name && x.Type == type.ToString());
                }
                return null;
            }
        }
        /// <summary>
        /// 添加DicItem
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="remark"></param>
        /// <returns></returns>
        public static Int64 AddMetadata(string name, MetaDataType type, string remark)
        {
            using (BMSContext context = new BMSContext())
            {
                PropertyMetadata entity = new PropertyMetadata
                {
                    Type = type.ToString(),
                    Name = name,
                    Remark = remark
                };
                context.PropertyMetadatas.Add(entity);
                if (context.SaveChanges() > 0)
                {
                    return entity.Id;
                }
                else
                {
                    return -1;
                }
            }
        }
        /// <summary>
        /// 刪除DicItem
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static int DelMetadata(int Id)
        {
            using (BMSContext context = new BMSContext())
            {
                if (context.PropertyMetadatas.Any(x => x.Id == Id))
                {
                    context.PropertyMetadatas.Remove(context.PropertyMetadatas.First(x => x.Id == Id));
                    return context.SaveChanges();
                }
                return 0;
            }
        }
        /// <summary>
        /// 添加DicItem
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static int AddMetadata(PropertyMetadata entity)
        {
            using (BMSContext context = new BMSContext())
            {
                context.PropertyMetadatas.Add(entity);
                return context.SaveChanges();
            }
        }
        public static int UpdateMetadata(PropertyMetadata entity)
        {
            if (entity != null)
            {
                using (BMSContext context = new BMSContext())
                {
                    var dbEntity = context.PropertyMetadatas.FirstOrDefault(x => x.Id == entity.Id);
                    if (dbEntity != null)
                    {
                        dbEntity.Name = entity.Name;
                        dbEntity.Remark = entity.Remark;
                        dbEntity.Type = entity.Type;
                        return context.SaveChanges();
                    }
                }
            }
            return 0;
        }
        /// <summary>
        /// 查询项目
        /// </summary>
        /// <param name="conditions"></param>
        /// <returns></returns>
        public static List<ProjectShow> SearchProject(SearchCondition conditions)
        {
            var list = new List<ProjectShow>();
            using (BMSContext context = new BMSContext())
            {
                var propertiesMetadata = context.PropertyMetadatas.ToList();

                var query = context.Projects.Select(x => x);

                if (conditions.CheckDateStart.HasValue)
                {
                    query = query.Where(x => x.CheckDate > conditions.CheckDateStart.Value);
                }
                if (conditions.CheckDateEnd.HasValue)
                {
                    DateTime dtTemp = conditions.CheckDateEnd.Value.AddDays(1);
                    query = query.Where(x => x.CheckDate < dtTemp);
                }
                if (conditions.Place > 0)
                {
                    query = query.Where(x => x.Place == conditions.Place);
                }
                if (conditions.BuildStruct > 0)
                {
                    query = query.Where(x => x.BuildStruct == conditions.BuildStruct);
                }
                if (conditions.ReportCondition > 0)
                {
                    query = query.Where(x => x.ReportCondition == conditions.ReportCondition);
                }
                if (!string.IsNullOrEmpty(conditions.ProjectName))
                {
                    query = query.Where(x => x.ProjectName.Contains(conditions.ProjectName));
                }
                if (!string.IsNullOrEmpty(conditions.InvestigateCase))
                {
                    query = query.Where(x => x.InvestigateCase.Contains(conditions.InvestigateCase));
                }
                if (!string.IsNullOrEmpty(conditions.Remark))
                {
                    query = query.Where(x => x.Remark.Contains(conditions.Remark));
                }
                if (!string.IsNullOrEmpty(conditions.Keyword))
                {
                    query = query.Where(x => x.Remark.Contains(conditions.Keyword)
                                          || x.ProjectName.Contains(conditions.Keyword)
                                          || x.Code.Contains(conditions.Keyword)
                                          || x.Address.Contains(conditions.Keyword)
                                          || x.BuildUnit.Contains(conditions.Keyword)
                                          || x.WorkChargre.Contains(conditions.Keyword)
                                          || x.Contact.Contains(conditions.Keyword)
                                          || x.ProjectDesc.Contains(conditions.Keyword)
                                          || x.ProjectProgress.Contains(conditions.Keyword)
                                          || x.BuildArea.Contains(conditions.Keyword)
                                          || x.InvestigateCase.Contains(conditions.Keyword));
                }
                var listProject = query.OrderByDescending(x => x.CreateDate).ToList();
                listProject.ForEach(x => list.Add(x.ToShow(propertiesMetadata)));
            }
            return list;
        }
    }
}
