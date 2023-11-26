window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, "Trade Added Successfully", { timeOut: 3000 });
    }
    if (type === "error") {
        toastr.error(message, "Operation Failed", { timeOut: 3000 });
    }
    if (type === "success1") {
        toastr.success(message, "Transaction Added Successfully", {timeOut: 3000 })
    }
}