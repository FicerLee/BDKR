﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.BDKRWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BDKRWS.IBDKRWS")]
    public interface IBDKRWS {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/门店信息_GetList", ReplyAction="http://tempuri.org/IBDKRWS/门店信息_GetListResponse")]
        System.Collections.Generic.List<DataAccess.门店ViewModel> 门店信息_GetList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/门店信息_AddNew", ReplyAction="http://tempuri.org/IBDKRWS/门店信息_AddNewResponse")]
        void 门店信息_AddNew(DataAccess.EditModels.门店EditModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/门店信息_Update", ReplyAction="http://tempuri.org/IBDKRWS/门店信息_UpdateResponse")]
        void 门店信息_Update(DataAccess.EditModels.门店EditModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/门店信息_Delete", ReplyAction="http://tempuri.org/IBDKRWS/门店信息_DeleteResponse")]
        int 门店信息_Delete(string 门店编码);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/门店信息_GetNewCode", ReplyAction="http://tempuri.org/IBDKRWS/门店信息_GetNewCodeResponse")]
        string 门店信息_GetNewCode();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/门店信息_GetEditModelById", ReplyAction="http://tempuri.org/IBDKRWS/门店信息_GetEditModelByIdResponse")]
        DataAccess.EditModels.门店EditModel 门店信息_GetEditModelById(string 门店信息编码);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/员工信息_GetList", ReplyAction="http://tempuri.org/IBDKRWS/员工信息_GetListResponse")]
        System.Collections.Generic.List<DataAccess.员工信息ViewModel> 员工信息_GetList(DataAccess.Filters.员工信息Filter filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/员工信息_AddNew", ReplyAction="http://tempuri.org/IBDKRWS/员工信息_AddNewResponse")]
        void 员工信息_AddNew(DataAccess.EditModels.员工信息EditModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/员工信息_Update", ReplyAction="http://tempuri.org/IBDKRWS/员工信息_UpdateResponse")]
        void 员工信息_Update(DataAccess.EditModels.员工信息EditModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/员工信息_Delete", ReplyAction="http://tempuri.org/IBDKRWS/员工信息_DeleteResponse")]
        void 员工信息_Delete(string 员工信息编码);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/员工信息_BatchImport", ReplyAction="http://tempuri.org/IBDKRWS/员工信息_BatchImportResponse")]
        int 员工信息_BatchImport(DataAccess.EditModels.员工信息EditModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/员工信息_GetNewCode", ReplyAction="http://tempuri.org/IBDKRWS/员工信息_GetNewCodeResponse")]
        string 员工信息_GetNewCode();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/员工信息_GetEditModelById", ReplyAction="http://tempuri.org/IBDKRWS/员工信息_GetEditModelByIdResponse")]
        DataAccess.EditModels.员工信息EditModel 员工信息_GetEditModelById(string 员工信息编码);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/工资表_GetList", ReplyAction="http://tempuri.org/IBDKRWS/工资表_GetListResponse")]
        System.Collections.Generic.List<DataAccess.工资表ViewModel> 工资表_GetList(DataAccess.Filters.工资表Filter filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/工资表_BatchUpdate", ReplyAction="http://tempuri.org/IBDKRWS/工资表_BatchUpdateResponse")]
        int 工资表_BatchUpdate(System.Collections.Generic.List<DataAccess.工资表ViewModel> list);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/仓库信息_GetList", ReplyAction="http://tempuri.org/IBDKRWS/仓库信息_GetListResponse")]
        System.Collections.Generic.List<DataAccess.仓库ViewModel> 仓库信息_GetList(DataAccess.Filters.仓库Filter filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/仓库信息_GetNewCode", ReplyAction="http://tempuri.org/IBDKRWS/仓库信息_GetNewCodeResponse")]
        string 仓库信息_GetNewCode();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/仓库信息_Update", ReplyAction="http://tempuri.org/IBDKRWS/仓库信息_UpdateResponse")]
        int 仓库信息_Update(DataAccess.EditModels.仓库EditModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/仓库信息_AddNew", ReplyAction="http://tempuri.org/IBDKRWS/仓库信息_AddNewResponse")]
        int 仓库信息_AddNew(DataAccess.EditModels.仓库EditModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/仓库信息_Delete", ReplyAction="http://tempuri.org/IBDKRWS/仓库信息_DeleteResponse")]
        int 仓库信息_Delete(string 仓库信息编码);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/仓库信息_GetEditModelById", ReplyAction="http://tempuri.org/IBDKRWS/仓库信息_GetEditModelByIdResponse")]
        DataAccess.EditModels.仓库EditModel 仓库信息_GetEditModelById(string 仓库信息编码);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/流水账明细清单_GetList", ReplyAction="http://tempuri.org/IBDKRWS/流水账明细清单_GetListResponse")]
        System.Collections.Generic.List<DataAccess.流水账明细清单ViewModel> 流水账明细清单_GetList(DataAccess.Filters.流水账明细Filter filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/流水账明细清单_BatchUpdate", ReplyAction="http://tempuri.org/IBDKRWS/流水账明细清单_BatchUpdateResponse")]
        int 流水账明细清单_BatchUpdate(DataAccess.EditModels.流水账清单EditModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/费用汇总明细表_GetList", ReplyAction="http://tempuri.org/IBDKRWS/费用汇总明细表_GetListResponse")]
        System.Collections.Generic.List<DataAccess.费用汇总明细表ViewModel> 费用汇总明细表_GetList(DataAccess.Filters.费用汇总表Filter filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/费用汇总明细表_BatchUpdate", ReplyAction="http://tempuri.org/IBDKRWS/费用汇总明细表_BatchUpdateResponse")]
        int 费用汇总明细表_BatchUpdate(System.Collections.Generic.List<DataAccess.EditModels.费用汇总表EditModel> model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/日常费用_GetList", ReplyAction="http://tempuri.org/IBDKRWS/日常费用_GetListResponse")]
        System.Collections.Generic.List<DataAccess.日常费用ViewModel> 日常费用_GetList(DataAccess.Filters.日常费用Filter filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/日常费用_BatchUpdate", ReplyAction="http://tempuri.org/IBDKRWS/日常费用_BatchUpdateResponse")]
        int 日常费用_BatchUpdate(System.Collections.Generic.List<DataAccess.日常费用ViewModel> models);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/损益表_GetList", ReplyAction="http://tempuri.org/IBDKRWS/损益表_GetListResponse")]
        System.Collections.Generic.List<DataAccess.损益表ViewModel> 损益表_GetList(DataAccess.Filters.损益表Filter filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/损益表_BatchUpdate", ReplyAction="http://tempuri.org/IBDKRWS/损益表_BatchUpdateResponse")]
        int 损益表_BatchUpdate(System.Collections.Generic.List<DataAccess.损益表ViewModel> models);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/货品信息_GetList", ReplyAction="http://tempuri.org/IBDKRWS/货品信息_GetListResponse")]
        System.Collections.Generic.List<DataAccess.货品信息ViewModel> 货品信息_GetList(DataAccess.Filters.货品信息Filter filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/货品信息_AddNew", ReplyAction="http://tempuri.org/IBDKRWS/货品信息_AddNewResponse")]
        int 货品信息_AddNew(DataAccess.EditModels.货品信息EditModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/货品信息_Update", ReplyAction="http://tempuri.org/IBDKRWS/货品信息_UpdateResponse")]
        int 货品信息_Update(DataAccess.EditModels.货品信息EditModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/货品信息_Delete", ReplyAction="http://tempuri.org/IBDKRWS/货品信息_DeleteResponse")]
        int 货品信息_Delete(string 货品信息编码);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/货品信息_GetNewCode", ReplyAction="http://tempuri.org/IBDKRWS/货品信息_GetNewCodeResponse")]
        string 货品信息_GetNewCode();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/货品信息_GetEditModelById", ReplyAction="http://tempuri.org/IBDKRWS/货品信息_GetEditModelByIdResponse")]
        DataAccess.EditModels.货品信息EditModel 货品信息_GetEditModelById(string 货品信息编码);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/菜品信息_GetList", ReplyAction="http://tempuri.org/IBDKRWS/菜品信息_GetListResponse")]
        System.Collections.Generic.List<DataAccess.菜品信息ViewModel> 菜品信息_GetList(DataAccess.Filters.菜品信息Filter filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/菜品信息_GetNewCode", ReplyAction="http://tempuri.org/IBDKRWS/菜品信息_GetNewCodeResponse")]
        string 菜品信息_GetNewCode();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/菜品信息_AddNew", ReplyAction="http://tempuri.org/IBDKRWS/菜品信息_AddNewResponse")]
        int 菜品信息_AddNew(DataAccess.EditModels.菜品信息EditModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/菜品信息_Update", ReplyAction="http://tempuri.org/IBDKRWS/菜品信息_UpdateResponse")]
        int 菜品信息_Update(DataAccess.EditModels.菜品信息EditModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/菜品信息_Delete", ReplyAction="http://tempuri.org/IBDKRWS/菜品信息_DeleteResponse")]
        int 菜品信息_Delete(string 菜品信息编码);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/库存信息_GetList", ReplyAction="http://tempuri.org/IBDKRWS/库存信息_GetListResponse")]
        System.Collections.Generic.List<DataAccess.库存信息ViewModel> 库存信息_GetList(DataAccess.Filters.库存信息Filter filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/货品类别_GetList", ReplyAction="http://tempuri.org/IBDKRWS/货品类别_GetListResponse")]
        System.Collections.Generic.List<DataAccess.EditModels.货品类别ViewModel> 货品类别_GetList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/货品类别_GetNewCode", ReplyAction="http://tempuri.org/IBDKRWS/货品类别_GetNewCodeResponse")]
        string 货品类别_GetNewCode();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/货品类别_AddNew", ReplyAction="http://tempuri.org/IBDKRWS/货品类别_AddNewResponse")]
        int 货品类别_AddNew(DataAccess.EditModels.货品类别EditModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/货品类别_Update", ReplyAction="http://tempuri.org/IBDKRWS/货品类别_UpdateResponse")]
        int 货品类别_Update(DataAccess.EditModels.货品类别EditModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/货品类别_Delete", ReplyAction="http://tempuri.org/IBDKRWS/货品类别_DeleteResponse")]
        int 货品类别_Delete(string 货品类别编码);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/采购价格_AddNew", ReplyAction="http://tempuri.org/IBDKRWS/采购价格_AddNewResponse")]
        int 采购价格_AddNew(DataAccess.EditModels.采购价格EditModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/采购价格_GetNewCode", ReplyAction="http://tempuri.org/IBDKRWS/采购价格_GetNewCodeResponse")]
        string 采购价格_GetNewCode();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/销售价格_AddNew", ReplyAction="http://tempuri.org/IBDKRWS/销售价格_AddNewResponse")]
        int 销售价格_AddNew(DataAccess.EditModels.销售价格EditModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/销售价格_GetNewCode", ReplyAction="http://tempuri.org/IBDKRWS/销售价格_GetNewCodeResponse")]
        string 销售价格_GetNewCode();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/货品BOM_GetNewCode", ReplyAction="http://tempuri.org/IBDKRWS/货品BOM_GetNewCodeResponse")]
        string 货品BOM_GetNewCode();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBDKRWS/货品BOM_AddNew", ReplyAction="http://tempuri.org/IBDKRWS/货品BOM_AddNewResponse")]
        void 货品BOM_AddNew(DataAccess.EditModels.货品BOMEditModel model);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBDKRWSChannel : Client.BDKRWS.IBDKRWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BDKRWSClient : System.ServiceModel.ClientBase<Client.BDKRWS.IBDKRWS>, Client.BDKRWS.IBDKRWS {
        
        public BDKRWSClient() {
        }
        
        public BDKRWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BDKRWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BDKRWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BDKRWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<DataAccess.门店ViewModel> 门店信息_GetList() {
            return base.Channel.门店信息_GetList();
        }
        
        public void 门店信息_AddNew(DataAccess.EditModels.门店EditModel model) {
            base.Channel.门店信息_AddNew(model);
        }
        
        public void 门店信息_Update(DataAccess.EditModels.门店EditModel model) {
            base.Channel.门店信息_Update(model);
        }
        
        public int 门店信息_Delete(string 门店编码) {
            return base.Channel.门店信息_Delete(门店编码);
        }
        
        public string 门店信息_GetNewCode() {
            return base.Channel.门店信息_GetNewCode();
        }
        
        public DataAccess.EditModels.门店EditModel 门店信息_GetEditModelById(string 门店信息编码) {
            return base.Channel.门店信息_GetEditModelById(门店信息编码);
        }
        
        public System.Collections.Generic.List<DataAccess.员工信息ViewModel> 员工信息_GetList(DataAccess.Filters.员工信息Filter filter) {
            return base.Channel.员工信息_GetList(filter);
        }
        
        public void 员工信息_AddNew(DataAccess.EditModels.员工信息EditModel model) {
            base.Channel.员工信息_AddNew(model);
        }
        
        public void 员工信息_Update(DataAccess.EditModels.员工信息EditModel model) {
            base.Channel.员工信息_Update(model);
        }
        
        public void 员工信息_Delete(string 员工信息编码) {
            base.Channel.员工信息_Delete(员工信息编码);
        }
        
        public int 员工信息_BatchImport(DataAccess.EditModels.员工信息EditModel model) {
            return base.Channel.员工信息_BatchImport(model);
        }
        
        public string 员工信息_GetNewCode() {
            return base.Channel.员工信息_GetNewCode();
        }
        
        public DataAccess.EditModels.员工信息EditModel 员工信息_GetEditModelById(string 员工信息编码) {
            return base.Channel.员工信息_GetEditModelById(员工信息编码);
        }
        
        public System.Collections.Generic.List<DataAccess.工资表ViewModel> 工资表_GetList(DataAccess.Filters.工资表Filter filter) {
            return base.Channel.工资表_GetList(filter);
        }
        
        public int 工资表_BatchUpdate(System.Collections.Generic.List<DataAccess.工资表ViewModel> list) {
            return base.Channel.工资表_BatchUpdate(list);
        }
        
        public System.Collections.Generic.List<DataAccess.仓库ViewModel> 仓库信息_GetList(DataAccess.Filters.仓库Filter filter) {
            return base.Channel.仓库信息_GetList(filter);
        }
        
        public string 仓库信息_GetNewCode() {
            return base.Channel.仓库信息_GetNewCode();
        }
        
        public int 仓库信息_Update(DataAccess.EditModels.仓库EditModel model) {
            return base.Channel.仓库信息_Update(model);
        }
        
        public int 仓库信息_AddNew(DataAccess.EditModels.仓库EditModel model) {
            return base.Channel.仓库信息_AddNew(model);
        }
        
        public int 仓库信息_Delete(string 仓库信息编码) {
            return base.Channel.仓库信息_Delete(仓库信息编码);
        }
        
        public DataAccess.EditModels.仓库EditModel 仓库信息_GetEditModelById(string 仓库信息编码) {
            return base.Channel.仓库信息_GetEditModelById(仓库信息编码);
        }
        
        public System.Collections.Generic.List<DataAccess.流水账明细清单ViewModel> 流水账明细清单_GetList(DataAccess.Filters.流水账明细Filter filter) {
            return base.Channel.流水账明细清单_GetList(filter);
        }
        
        public int 流水账明细清单_BatchUpdate(DataAccess.EditModels.流水账清单EditModel model) {
            return base.Channel.流水账明细清单_BatchUpdate(model);
        }
        
        public System.Collections.Generic.List<DataAccess.费用汇总明细表ViewModel> 费用汇总明细表_GetList(DataAccess.Filters.费用汇总表Filter filter) {
            return base.Channel.费用汇总明细表_GetList(filter);
        }
        
        public int 费用汇总明细表_BatchUpdate(System.Collections.Generic.List<DataAccess.EditModels.费用汇总表EditModel> model) {
            return base.Channel.费用汇总明细表_BatchUpdate(model);
        }
        
        public System.Collections.Generic.List<DataAccess.日常费用ViewModel> 日常费用_GetList(DataAccess.Filters.日常费用Filter filter) {
            return base.Channel.日常费用_GetList(filter);
        }
        
        public int 日常费用_BatchUpdate(System.Collections.Generic.List<DataAccess.日常费用ViewModel> models) {
            return base.Channel.日常费用_BatchUpdate(models);
        }
        
        public System.Collections.Generic.List<DataAccess.损益表ViewModel> 损益表_GetList(DataAccess.Filters.损益表Filter filter) {
            return base.Channel.损益表_GetList(filter);
        }
        
        public int 损益表_BatchUpdate(System.Collections.Generic.List<DataAccess.损益表ViewModel> models) {
            return base.Channel.损益表_BatchUpdate(models);
        }
        
        public System.Collections.Generic.List<DataAccess.货品信息ViewModel> 货品信息_GetList(DataAccess.Filters.货品信息Filter filter) {
            return base.Channel.货品信息_GetList(filter);
        }
        
        public int 货品信息_AddNew(DataAccess.EditModels.货品信息EditModel model) {
            return base.Channel.货品信息_AddNew(model);
        }
        
        public int 货品信息_Update(DataAccess.EditModels.货品信息EditModel model) {
            return base.Channel.货品信息_Update(model);
        }
        
        public int 货品信息_Delete(string 货品信息编码) {
            return base.Channel.货品信息_Delete(货品信息编码);
        }
        
        public string 货品信息_GetNewCode() {
            return base.Channel.货品信息_GetNewCode();
        }
        
        public DataAccess.EditModels.货品信息EditModel 货品信息_GetEditModelById(string 货品信息编码) {
            return base.Channel.货品信息_GetEditModelById(货品信息编码);
        }
        
        public System.Collections.Generic.List<DataAccess.菜品信息ViewModel> 菜品信息_GetList(DataAccess.Filters.菜品信息Filter filter) {
            return base.Channel.菜品信息_GetList(filter);
        }
        
        public string 菜品信息_GetNewCode() {
            return base.Channel.菜品信息_GetNewCode();
        }
        
        public int 菜品信息_AddNew(DataAccess.EditModels.菜品信息EditModel model) {
            return base.Channel.菜品信息_AddNew(model);
        }
        
        public int 菜品信息_Update(DataAccess.EditModels.菜品信息EditModel model) {
            return base.Channel.菜品信息_Update(model);
        }
        
        public int 菜品信息_Delete(string 菜品信息编码) {
            return base.Channel.菜品信息_Delete(菜品信息编码);
        }
        
        public System.Collections.Generic.List<DataAccess.库存信息ViewModel> 库存信息_GetList(DataAccess.Filters.库存信息Filter filter) {
            return base.Channel.库存信息_GetList(filter);
        }
        
        public System.Collections.Generic.List<DataAccess.EditModels.货品类别ViewModel> 货品类别_GetList() {
            return base.Channel.货品类别_GetList();
        }
        
        public string 货品类别_GetNewCode() {
            return base.Channel.货品类别_GetNewCode();
        }
        
        public int 货品类别_AddNew(DataAccess.EditModels.货品类别EditModel model) {
            return base.Channel.货品类别_AddNew(model);
        }
        
        public int 货品类别_Update(DataAccess.EditModels.货品类别EditModel model) {
            return base.Channel.货品类别_Update(model);
        }
        
        public int 货品类别_Delete(string 货品类别编码) {
            return base.Channel.货品类别_Delete(货品类别编码);
        }
        
        public int 采购价格_AddNew(DataAccess.EditModels.采购价格EditModel model) {
            return base.Channel.采购价格_AddNew(model);
        }
        
        public string 采购价格_GetNewCode() {
            return base.Channel.采购价格_GetNewCode();
        }
        
        public int 销售价格_AddNew(DataAccess.EditModels.销售价格EditModel model) {
            return base.Channel.销售价格_AddNew(model);
        }
        
        public string 销售价格_GetNewCode() {
            return base.Channel.销售价格_GetNewCode();
        }
        
        public string 货品BOM_GetNewCode() {
            return base.Channel.货品BOM_GetNewCode();
        }
        
        public void 货品BOM_AddNew(DataAccess.EditModels.货品BOMEditModel model) {
            base.Channel.货品BOM_AddNew(model);
        }
    }
}
