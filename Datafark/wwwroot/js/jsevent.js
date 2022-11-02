
function getCategory(id) {
    $.ajax({
        url: '/Home/ProductWithParameter/',
        type: 'GET',
        dataType: 'html',
        data: {
            'categoryId': id},
        success: function (d) {
            $("#productList").html(d);
        }
    });
}


function ready() {
    getMiniCart();
    getMenu();
}
function getMenu() {
    $.get("/Home/Menu", function (d) {
        $("#upmenu").html(d);
    });
}
function getMiniCart() {
    $.get("/Home/MiniCartList", function (d) {
        $("#minicartlist").html(d);
    });
}
$(document).ready(function () {
    
    
    $("#searchbar").keypress(function (event) {
        event.stopPropagation();
        event.stopImmediatePropagation();
        searchfunc(this);
    }
    );
    $("#cartcustomertitle").click(function (event) {
        event.stopPropagation();
        event.stopImmediatePropagation();
        getCustomer();
    }
    );

    $(".active").click(function (event) {
        event.stopPropagation();
        event.stopImmediatePropagation();
        getCategory($(this).data('id'))
    }
    );
    $(".cart").click(function (event) {
        event.stopPropagation();
        event.stopImmediatePropagation();
        addBasket($(this).data('id'));
    }
    );
    $(".cartvariant").click(function (event) {
        event.stopPropagation();
        event.stopImmediatePropagation();
        openvariantmodal($(this).data('id'));
    }
    );
    $(".cartdelete").click(function (event) {
        event.stopPropagation();
        event.stopImmediatePropagation();
        deletebasketdetail($(this).data('id'));
    }
    );
    $(".item-quantity").mouseup(function (event) {
        event.stopPropagation();
        event.stopImmediatePropagation();
        updatebasketdetail(this);
    }
    );

    $(".cartedit").click(function (event) {
        event.stopPropagation();
        event.stopImmediatePropagation();
        updatebasketdetailmodal($(this).data('id'));
    }
    );
    $(".closemodal").click(function (event) {
        closemodal();
    }
    );
    $('ul.pagination > li.disabled > a').addClass('page-link');


    $("#updatecartvisible").click(function (event) {
        event.stopPropagation();
        event.stopImmediatePropagation();
        updatecartvisible();
    }
    );
    $("#updatecartdetail").click(function (event) {
        event.stopPropagation();
        event.stopImmediatePropagation();
        getbasketeditmodal();
    }
    );
    
    $("#deletecartdetail").click(function (event) {
        event.stopPropagation();
        event.stopImmediatePropagation();
        deletecartdetail();
    }
    );
    $("#printcartdetail").click(function (event) {
        event.stopPropagation();
        event.stopImmediatePropagation();
        printcartdetailprint();
    }
    );
    $("#parkedcartlist").click(function (event) {
        event.stopPropagation();
        event.stopImmediatePropagation();
        parkedcartlist();
    }
    );

    $("#datenoworder").click(function (event) {
        event.stopPropagation();
        event.stopImmediatePropagation();
        datenoworder();
    }
    );
    $("#searchbarReturnOrder").keypress(function (event) {
        event.stopPropagation();
        event.stopImmediatePropagation();
      //  event.preventDefault();
        searchReturnOrder(this);
    }
    );
    $("#secondstep").click(function (event) {
        event.stopPropagation();
        event.stopImmediatePropagation();
        returnordercheck(this);
    }
    );
});
function parkedcartlist() {
    try {
        LoaderSet('block');
        $.ajax({
            url: '/Home/GetParkedBasketList/',
            type: 'GET',
            dataType: 'json',
            success: function (response) {
                if (response.data.length > 0) {
                    const div = document.createElement('div');
                    var str = "";
                    str = `
<div class="input-group">
        <input id="filtersearch" type="text" class="form-control" placeholder="Aramak için yazın..." onkeyup="filtercustomer(this)">
    </div>
    <table class="table table-striped" id="customertbl">
        <thead>
            <tr>
                <th></th>
                <th>Sepet No</th>
                <th>Müşteri Ad Soyad(Ünvan)</th>
                <th>Sepet Detayı</th>
            </tr>
        </thead>
        <tbody class="searchable">`;
                    $.each(response.data, function (i) {
                        var prod = "";
                        if (response.data[i].basketDetails.length > 0) {
                            $.each(response.data[i].basketDetails, function (x) {
                                prod += response.data[i].basketDetails[x].productSku.title + ' x ' + response.data[i].basketDetails[x].quantity + "<br>";
                            });
                        }
                        const div = document.createElement('div');
                        str += `<tr>
                    <td><button type="button" onclick="changebasket(${response.data[i].id})"  class="btn btn-success btn-sm main-color-text " style="color:white" data-id="${response.data[i].id}"> SEÇ</button></td>
                    <td style="padding-left:25px">${response.data[i].id} </td>
                    <td>${response.data[i].customer.name + ' ' + response.data[i].customer.surname + '( ' + response.data[i].customer.title + ' )'}</td>
                    <td style="padding-left:25px" ><i class="bi bi-info-circle-fill tipsmain" style="font-style: normal;cursor:pointer;font-size:20px" ><i class="tipsdetail" style="font-style: normal"> ${prod} </i> </i>  ${response.data[i].basketDetails.length}</td>
                </tr>`;

                    });
                    str += `</tbody>
    </table>`;
                    div.innerHTML = str;
                    document.getElementById('modal-body').appendChild(div);
                    document.getElementById("modTitle").innerHTML = "Park Durumundaki Sepetler";
                    document.getElementById("myModal").style.display = "block";
                    document.getElementById("mdlupd").style.display = "none";
                    /* document.getElementById("mdlupd").setAttribute("onclick", "addBasket(" + response.data.id + ")");*/
                }

            },
            error: function (response) {
                SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
            }
        });
        
    } catch {
        LoaderSet('none');
    }
    finally {
        LoaderSet('none');
    }



}

function datenoworder() {
    try {
        LoaderSet('block');
        $.ajax({
            url: '/Home/GetDateNowOrder/',
            type: 'GET',
            dataType: 'json',
            success: function (response) {
                if (response.data.length > 0) {
                    const div = document.createElement('div');
                    var str = "";
                    str = `
<div class="input-group">
        <input id="filtersearch" type="text" class="form-control" placeholder="Aramak için yazın..." onkeyup="filtercustomer(this)">
    </div>
    <table class="table table-striped" id="customertbl">
        <thead>
            <tr>
                <th>Sipariş No</th>
                <th>Müşteri Ad Soyad(Ünvan)</th>
                <th>Sipariş Tutarı(Kdv Dahil)</th>
                <th>Sepet Detayı</th>
            </tr>
        </thead>
        <tbody class="searchable">`;
                    $.each(response.data, function (i) {
                        var prod = "";
                        var price = 0;
                        if (response.data[i].orderDetails.length > 0) {
                            $.each(response.data[i].orderDetails, function (x) {
                                prod += response.data[i].orderDetails[x].productSkus.title + ' x ' + response.data[i].orderDetails[x].quantity + "<br>";
                                price += response.data[i].orderDetails[x].lineNetPrice;
                            });
                        }
                        const div = document.createElement('div');
                        str += `<tr>                    
                    <td style="padding-left:25px">${response.data[i].id} </td>
                    <td>${response.data[i].customer.name + ' ' + response.data[i].customer.surname + '( ' + response.data[i].customer.title + ' )'}</td>
                    <td>${price}</td>
                    <td style="padding-left:25px" ><i class="bi bi-info-circle-fill tipsmain" style="font-style: normal;cursor:pointer;font-size:20px" ><i class="tipsdetail" style="font-style: normal"> ${prod} </i> </i>  ${response.data[i].orderDetails.length}</td>
                </tr>`;

                    });
                    str += `</tbody>
    </table>`;
                    div.innerHTML = str;
                    document.getElementById('modal-body').appendChild(div);
                    document.getElementById("modTitle").innerHTML = "Bugün Yapılan Satışlar";
                    document.getElementById("myModal").style.display = "block";
                    document.getElementById("mdlupd").style.display = "none";
                    /* document.getElementById("mdlupd").setAttribute("onclick", "addBasket(" + response.data.id + ")");*/
                }

            },
            error: function (response) {
                SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
            }
        });
     
    } catch {

    }
    finally {
        LoaderSet('none');
    }
}

function payout(e,id,type,order) {
    try {
        LoaderSet('block');
        var url = "";
        if (order == 0)
            url = "/Home/Payout/"
        else
            url = "/Home/ReturnPayout/"
        if(id ==0 )
        id = e.getAttribute('data-id');
        $.ajax({
            url: url,
            type: 'POST',
            dataType: 'json',
            data: {
                'id': id,
                'type': type
            },
            success: function (response) {
                SetNotify('success', 'Bilgi', response, 5000);
                if (order == 0) {
                    closemodal();
                    getMiniCart();
                }
                else {
                    document.getElementById("laststep").click();
                    
                }
              
            },
            error: function (response) {
                SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
            }
        });
      
    } catch {
       
    } 
    finally {
        LoaderSet('none');
    }
}
function changebasket(id) {
    try {
        LoaderSet('block');
        $.ajax({
            url: '/Home/ChangeBasket/',
            type: 'POST',
            dataType: 'json',
            data: { 'basketId': id },
            success: function (response) {
                SetNotify('success', 'Bilgi', response, 3000);
                closemodal();
                getMiniCart();
            },
            error: function (response) {
                SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
            }
        });
    } catch {
        LoaderSet('none');
    }
 
}
function updatebasketcustomer(id) {
    try {
        LoaderSet('block');
        $.ajax({
            url: '/Home/UpdateBasket/',
            type: 'POST',
            dataType: 'json',
            data: { 'CustomerId': id },
            success: function (response) {
                SetNotify('success', 'Bilgi', response, 3000);
                closemodal();
                getMiniCart();
            },
            error: function (response) {
                SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
            }
        });
    } catch {
       
    }
    finally {
        LoaderSet('none');
    }
}
function deletecartdetail() {
    try {
        LoaderSet('block');
        $.ajax({
            url: '/Home/DeleteBasketDetail/',
            type: 'POST',
            dataType: 'json',
            data: {
                'Status': false
            },
            success: function (response) {
                if (!response.includes("hide")) {
                    SetNotify('success', 'Bilgi', response, 3000);
                    closemodal();
                    getMiniCart();
                }
            },
            error: function (response) {
                SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
            }
        });
    } catch {
     
    }
    finally {
        LoaderSet('none');
    }
  
}
function updatecartvisible(id) {
    try {
        LoaderSet('block');
        $.ajax({
            url: '/Home/UpdateBasket/',
            type: 'POST',
            dataType: 'json',
            data: {
                'Status': false
            },
            success: function (response) {
                if (!response.includes("hide")) {
                    SetNotify('success', 'Bilgi', response, 3000);
                    closemodal();
                    getMiniCart();
                }
            },
            error: function (response) {
                SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
            }
        });
    } catch {
       
    }
    finally {
        LoaderSet('none');
    }
   
}
function printcartdetailprint() {
    try {
        LoaderSet('block');
        $.ajax({
            url: '/Home/GetBasketDetailPrint/',
            type: 'GET',
            dataType: 'json',
            success: function (response) {
                if (response.data.length > 0) {
                    const div = document.createElement('div');
                    var str = "";
                    str = `<div id="invoice-POS" style="box-shadow: 0 0 1in -0.25in rgba(0, 0, 0, 0.5);padding:2mm;margin: 0 auto;width: 5cm;background: #FFF">
    
    <center id="top" style=" border-bottom: 1px solid #EEE;min-height: 20px;">
      <div class="info" style="display: block;margin-left: 0;"> 
        <h2 style="font-size: .9em;">Firma Adı</h2>
      </div><!--End Info-->
    </center><!--End InvoiceTop-->
    
    <div id="mid" style=" border-bottom: 1px solid #EEE;min-height: 50px;">
      <center>
      <div class="info"  style="display: block;margin-left: 0;">
       <p style="font-size: .7em;color: #666;line-height: 1.2em;"> 
            Address : street city, state 0000</br>
            Email   : JohnDoe@gmail.com</br>
            Phone   : 555-555-5555</br>
        </p>

      </div>
</center>
    </div><!--End Invoice Mid-->
    <div id="bot" style=" border-bottom: 1px solid #EEE;min-height: 50px;">
					<div id="table">
						<table style="width: 100%;border-collapse: collapse;">
							<tr class="tabletitle" style="font-size: .5em;background: #EEE;">
								<td class="item" style="width: 24mm;"><h2 style="font-size: .9em;">Ürün</h2></td>
								<td class="Hours"><h2 style="font-size: .9em;">Miktar</h2></td>
								<td class="Rate"><h2 style="font-size: .9em;">Tutar</h2></td>
							</tr>`;
                    $.each(response.data, function (i) {
                        const div = document.createElement('div');
                        str += `<tr class="service" style="border-bottom: 1px solid #EEE;">
								<td class="tableitem"><p class="itemtext" style="font-size: .5em;">${response.data[i].productSku.title}</p></td>
								<td class="tableitem"><p class="itemtext" style="font-size: .5em;">${response.data[i].quantity}</p></td>
								<td class="tableitem"><p class="itemtext" style="font-size: .5em;">${response.data[i].lineTotal}</p></td>
							</tr>`;

                    });


                    str += `	<tr class="tabletitle" style="font-size: .5em;background: #EEE;">
								<td></td>
								<td class="Rate"><h2 style="font-size: .9em;">Kdv</h2></td>
								<td class="payment"><h2 style="font-size: .9em;">${response.data[0].basket.invoicTaxTotal} TL</h2></td>
							</tr>
							<tr class="tabletitle" style="font-size: .5em;background: #EEE;">
								<td></td>
								<td class="Rate"><h2 style="font-size: .9em;">Toplam</h2></td>
								<td class="payment"><h2 style="font-size: .9em;">${response.data[0].basket.invoiceTotal + response.data[0].basket.invoicTaxTotal} TL</h2></td>
							</tr>
						</table>
					</div><!--End Table-->

					<div id="legalcopy" style="margin-top: 5mm;font-size:0.88em">
						<p class="legal" style="font-size: .7em;color: #666;line-height: 1.2em;">
<strong>Bizi tercih ettiğiniz için teşekkür ederiz..</strong>  İade / Değişim işlemleri için bu fişin ibrazı zorunludur. Lütfen saklayınız..
						</p>
					</div>
				</div>
  </div>`;
                    div.innerHTML = str;
                    var a = window.open('', '', 'titlebar=1,menubar=1');
                    a.document.write(str);
                    a.document.close();
                    a.print();
                }

            },
            error: function (response) {
                SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
            }
        });
    } catch {
        
    }
    finally {
        LoaderSet('none');
    }
   

}
function getbasketeditmodal() {
    try {
        LoaderSet('block');
        $.ajax({
            url: '/Home/GetBasket/',
            type: 'GET',
            dataType: 'json',
            success: function (response) {
                const div = document.createElement('div');
                div.innerHTML = ` <!-- modal body start -->
                <input type="hidden" id="mdlid" value="0" />
                <div class="row g-3">
                   
                    <div class="col">
                        <label class="form-label">İndirim</label>
                        <input type="number" id="mdlDiscount" class="form-control" placeholder="Fiyat" aria-label="Last name" min="0" step="0.01">
                    </div>
                    <div class="col" style="margin-top:40px">
                        <div class="form-check">
                          <input class="form-check-input" type="radio" name="rdDiscount1" id="flexRadioDefault1">
                          <label class="form-check-label" >
                            İndirim Oranı
                          </label>
                        </div>
                        <div class="form-check">
                          <input class="form-check-input" type="radio" name="rdDiscount1" id="flexRadioDefault2">
                          <label class="form-check-label">
                             İndirim Tutarı
                          </label>
                        </div>
                    </div>
                </div>
                <div class="col-12">
                    <label class="form-label">Sepet Açıklaması</label>
                    <input type="text" class="form-control" id="mdlNote" placeholder="Örnek : Paketleme istiyorum..">
                </div>
                <!-- modal body end -->`;

                document.getElementById('modal-body').appendChild(div);

                document.getElementById("modTitle").innerHTML = "Sepet Düzenle";
                document.getElementById("myModal").style.display = "block";
                document.getElementById("mdlid").value = response.data.id;
                if (response.data.discountType == 1) {
                    document.getElementById("flexRadioDefault1").checked = true;
                    document.getElementById("flexRadioDefault2").checked = false;
                }
                else {
                    document.getElementById("flexRadioDefault1").checked = false;
                    document.getElementById("flexRadioDefault2").checked = true;
                }
                document.getElementById("mdlDiscount").value = response.data.discount;
                document.getElementById("mdlNote").value = response.data.notes;
                document.getElementById("mdlupd").style.display = "block";
                document.getElementById("mdlupd").setAttribute("onclick", "updatebaketall()");
            },
            error: function (response) {
                SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
            }
        });
    } catch {
     
    }
    finally {
        LoaderSet('none');
    }
   
}

////basket güncelleme
function updatebaketall() {
    try {
        LoaderSet('block');
        $.ajax({
            url: '/Home/UpdateBasket/',
            type: 'POST',
            dataType: 'json',
            data: {
                'Id': document.getElementById("mdlid").value,
                'Discount': document.getElementById("mdlDiscount").value.replace('.', ','),
                'DiscountType': document.getElementById("flexRadioDefault1").checked == true ? 1 : 2,
                'Notes': document.getElementById("mdlNote").value,
            },
            success: function (response) {
                closemodal();
                SetNotify('success', 'Bilgi', response, 3000);
                getMiniCart();
            },
            error: function (response) {
                SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
            }
        });
    } catch {
      
    }
    finally {
        LoaderSet('none');
    }
   
}
function filtercustomer() {
    try {
        LoaderSet('block');
        var obj = document.getElementById("filtersearch");
        var rex = new RegExp(obj.value, 'i');
        $('.searchable tr').hide();
        $('.searchable tr').filter(function () {
            return rex.test($(this).text());
        }).show();
    } catch {
       
    }
    finally {
        LoaderSet('none');
    }
  
}
function newcustomermodal() {
    try {
        LoaderSet('block');
        closemodal();
        Promise.resolve();
        const div = document.createElement('div');
        div.innerHTML = `
                <div class="row g-3">
                    <div class="col">
                        <label class="form-label">Ad</label>
                        <input type="text" id="mdlCustomerName" class="form-control" required>
                    </div>
                    <div class="col">
                        <label class="form-label">Soyad</label>
                        <input type="text" id="mdlCustomerSurName" class="form-control" required>
                    </div>
                </div>
                <div class="col-12">
                    <label class="form-label">Müşteri Ünvanı</label>
                    <input type="text"   id="mdlTitle" class="form-control">
                </div>
                <!--modal body end-- >`;

        document.getElementById('modal-body').appendChild(div);
        document.getElementById("modTitle").innerHTML = "Yeni Müşteri";
        document.getElementById("myModal").style.display = "block";
        document.getElementById("mdlupd").style.display = "block";
        document.getElementById("mdlupd").innerHTML = "Kaydet";
        document.getElementById("mdlupd").setAttribute("onclick", "addnewcustomer()");
    } catch {
        
    }
    finally {
        LoaderSet('none');
    }
 
}
function addnewcustomer() {
    try {
        LoaderSet('block');
        var custname = document.getElementById("mdlCustomerName").value;
        var custsurname = document.getElementById("mdlCustomerSurName").value;
        var custtitle = document.getElementById("mdlTitle").value;
        if (custname.length > 0 && custsurname.length > 0) {
            $.ajax({
                url: '/Home/AddNewCustomer/',
                type: 'POST',
                dataType: 'json',
                data: {
                    'Name': custname,
                    'Surname': custsurname,
                    'Title': custtitle,
                },
                success: function (response) {
                    SetNotify('success', 'Bilgi', response.data, 3000);
                    closemodal();
                    getMiniCart();
                },
                error: function (response) {
                    SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
                }
            });
        }
        else {
            SetNotify('warning', 'Hata', "Zorunlu alanları doldurunuz!", 3000);
        }
    } catch {
     
    }
    finally {
        LoaderSet('none');
    }
}

function getCustomer() {
    try {
        LoaderSet('block');
        $.ajax({
            url: '/Home/BasketCustomerList/',
            type: 'GET',
            dataType: 'json',
            success: function (response) {
                if (response.data.length > 0) {
                    const div = document.createElement('div');
                    var str = "";
                    str = `<button type="button" class="btn btn-success btn-sm main-color-text " style="float:left;color:white;margin-bottom:5px" onclick="newcustomermodal()">Müşteri Ekle</button>
<div class="input-group">
        <input id="filtersearch" type="text" class="form-control" placeholder="Aramak için yazın..." onkeyup="filtercustomer()">
    </div>
    <table class="table table-striped" id="customertbl">
        <thead>
            <tr>
                <th></th>
                <th>Cari Kodu</th>
                <th>Cari Unvan</th>
            </tr>
        </thead>
        <tbody class="searchable">`;
                    $.each(response.data, function (i) {
                        const div = document.createElement('div');
                        str += `<tr>
                    <td>
                        <button type="button" onclick="updatebasketcustomer(${response.data[i].id})"  class="btn btn-success btn-sm main-color-text " style="color:white" data-id="${response.data[i].id}">
                           SEÇ
                        </button>
                    </td>
                    <td>${response.data[i].code}</td>
                    <td>${response.data[i].title}</td>
                </tr>`;

                    });
                    str += `</tbody>
    </table>`;
                    div.innerHTML = str;
                    document.getElementById('modal-body').appendChild(div);
                    document.getElementById("modTitle").innerHTML = "Müşteriler";
                    document.getElementById("myModal").style.display = "block";
                    document.getElementById("mdlupd").style.display = "none";
                    /* document.getElementById("mdlupd").setAttribute("onclick", "addBasket(" + response.data.id + ")");*/
                }

            },
            error: function (response) {
                SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
            }
        });
    } catch {
       
    }
    finally {
        LoaderSet('none');
    }
   

}
function addBasket(id) {
    try {
        LoaderSet('block');
        $.ajax({
            url: '/Home/AddBasket/',
            type: 'POST',
            dataType: 'json',
            data: { 'ProductSkuId': id },
            success: function (response) {
                SetNotify('success', 'Bilgi', response, 3000);
                getMiniCart();
            },
            error: function (response) {
                SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
            }
        });
    } catch {
       
    }
    finally {
        LoaderSet('none');
    }
  
}
function openvariantmodal(id) {
    try {
        LoaderSet('block');
        $.ajax({
            url: '/Home/GetProductSkuList/',
            type: 'GET',
            dataType: 'json',
            data: { 'ProductId': id },
            success: function (response) {
                if (response.data.length > 0) {
                    $.each(response.data, function (i) {
                        var image = unitprice = ``;
                        if (response.data[i].productSkuImages.length > 0)
                            image = `<img class="img" src="${response.data[i].productSkuImages[0].ImageUrl}">`;
                        else
                            image = `<img class="img" src="/images/logo.png">`;
                        if (response.data[i].productSkuPrices.length > 0) {
                            $.each(response.data[i].productSkuPrices, function (p) {
                                if (response.data[i].productSkuPrices[p].productSkuPriceTypeId == 2) {
                                    unitprice = response.data[i].productSkuPrices[p].price;
                                    return false;
                                }

                            });
                        }
                        else {
                            unitprice = 0;
                        }
                        const div = document.createElement('div');
                        div.innerHTML = `<div class="container page-wrapper">
        <div class="page-inner">
            <div class="row">
                <div class="el-wrapper">
                    <div class="box-up">
                        ${image}
                        <div class="img-info">
                            <div class="info-inner">
                                <span class="p-name">${response.data[i].title}</span>
                                <span class="p-company">${response.data[i].barcode}</span>
                            </div>
                        </div>
                    </div>

                    <div class="box-down">
                        <div class="h-bg">
                            <div class="h-bg-inner"></div>
                        </div>
                            <a class="cart" onclick="addBasket(${response.data[i].id})" href="#" data-id="${response.data[i].id}" >
                                <span class="price">Fiyat : ${unitprice}</span>
                                <span class="add-to-cart">
                                    <span class="txt">Sepete Ekle</span>
                                </span>
                            </a>
                    </div>
                </div>
            </div>
        </div>
    </div>`;
                        document.getElementById('modal-body').appendChild(div);
                    });



                    document.getElementById("modTitle").innerHTML = 'Ürün Adı : ' + response.data[0].product.title;
                    document.getElementById("myModal").style.display = "block";
                    document.getElementById("mdlupd").style.display = "none";
                }

            },
            error: function (response) {
                SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
            }
        });
    } catch {
       
    }
    finally {
        LoaderSet('none');
    }
    
} 
function deletebasketdetail(id) {
    try {
        LoaderSet('block');
        $.ajax({
            url: '/Home/DeleteBasketProduct/',
            type: 'POST',
            dataType: 'json',
            data: { 'Id': id },
            success: function (response) {
                SetNotify('success', 'Bilgi', response, 3000);
                getMiniCart();
            },
            error: function (response) {
                SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
            }
        });
    } catch {
        
    }
    finally {
        LoaderSet('none');
    }
 
}
function updatebasketdetail(e) {
    try {
        LoaderSet('block');
        if (e.value != 0) {
            $.ajax({
                url: '/Home/UpdateBasketProduct/',
                type: 'POST',
                dataType: 'json',
                data: {
                    'Id': e.getAttribute('data-id'),
                    'Quantity': e.value
                },
                success: function (response) {
                    SetNotify('success', 'Bilgi', response, 3000);
                    getMiniCart();

                },
                error: function (response) {
                    SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
                }
            });
        }
        else {
            SetNotify('error', 'Hata', "Miktar en az 1 olmalıdır!", 3000);
        }

    } catch {
        
    }
    finally {
        LoaderSet('none');
    }
}
function updatebasketdetailall() {
    try {
        LoaderSet('block');
        $.ajax({
            url: '/Home/UpdateBasketProduct/',
            type: 'POST',
            dataType: 'json',
            data: {
                'Id': document.getElementById("mdlid").value,
                'Quantity': document.getElementById("mdlQuantity").value,
                'UnitPrice': document.getElementById("mdlPrice").value.replace('.', ','),
                'Discount': document.getElementById("mdlDiscount").value,
                'Notes': document.getElementById("mdlNote").value,
            },
            success: function (response) {
                closemodal();
                SetNotify('success', 'Bilgi', response, 3000);
                getMiniCart();
            },
            error: function (response) {
                SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
            }
        });
    } catch {
      
    }
    finally {
        LoaderSet('none');
    }
}
function updatebasketdetailmodal(id) {
    try {
        LoaderSet('block');
        $.ajax({
            url: '/Home/GetBasketDetail/',
            type: 'GET',
            dataType: 'json',
            data: { 'Id': id },
            success: function (response) {
                const div = document.createElement('div');
                div.innerHTML = ` <!-- modal body start -->
                <input type="hidden" id="mdlid" value="0" />
                <div class="row g-3">
                    <div class="col">
                        <label class="form-label">Miktar</label>
                        <input type="number" id="mdlQuantity" class="form-control" placeholder="Miktar(En az 1)" aria-label="First name" min="1">
                    </div>
                    <div class="col">
                        <label class="form-label">Fiyat</label>
                        <input type="number" id="mdlPrice" class="form-control" placeholder="Fiyat" aria-label="Last name" min="0" step="0.01">
                    </div>
                    <div class="col">
                        <label class="form-label">İndirim(%)</label>
                        <input type="number" id="mdlDiscount" class="form-control" placeholder="İndirim" aria-label="Last name" min="0">
                    </div>
                </div>
                <div class="col-12">
                    <label class="form-label">Satır açıklaması</label>
                    <input type="text" class="form-control" id="mdlNote" placeholder="Örnek : Paketleme istiyorum..">
                </div>
                <!-- modal body end -->`;

                document.getElementById('modal-body').appendChild(div);

                document.getElementById("modTitle").innerHTML = response.data.productSku.title;
                document.getElementById("myModal").style.display = "block";
                document.getElementById("mdlid").value = response.data.id;
                document.getElementById("mdlQuantity").value = response.data.quantity;
                document.getElementById("mdlPrice").value = response.data.unitPrice;
                document.getElementById("mdlDiscount").value = response.data.discount;
                document.getElementById("mdlNote").value = response.data.notes;
                document.getElementById("mdlupd").style.display = "block";
                document.getElementById("mdlupd").setAttribute("onclick", "updatebasketdetailall()");
            },
            error: function (response) {
                SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
            }
        });
    } catch {
      
    } finally {
        LoaderSet('none');
    }
   
}
function closemodal() {
    document.getElementById("myModal").style.display = "none";
    document.getElementById('modal-body').innerHTML = "";
    document.getElementById("mdlupd").innerHTML = "Güncelle";
}
function searchfunc(obj) {
    try {
        LoaderSet('block');
        if (event.keyCode == 13) {
            categoryId = 0;
            SayfaSayisi = 0;
            $.ajax({
                url: '/Home/ProductWithParameter/',
                type: 'GET',
                dataType: 'html',
                data: { 'word': obj.value },
                success: function (d) {
                    $("#productList").html(d);
                }
            });
        } else {
            return false;
        }
    } catch {
     
    } finally {
        LoaderSet('none');
    }
}

///RETURNORDER START
function searchReturnOrder(obj) {
    try {
       
        if (event.keyCode == 13) {
            LoaderSet('block');
            event.preventDefault();

            document.getElementById('listSeachOrder').innerHTML = "";
            $.ajax({
                url: '/Home/GetOrderWithSearch/',
                type: 'GET',
                dataType: 'json',
                data: { 'value': obj.value },
                success: function (response) {
                    if (response.data.length > 0) {
                        const div = document.createElement('div');
                        var str = "";
                        str = `
                       <div class="input-group">
                           <input id="filtersearch" type="text" class="form-control" placeholder="Aramak için yazın..." onkeyup="filtercustomer()">
                       </div>
                       <table class="table table-striped" id="customertbl">
                           <thead>
                               <tr>
                                   <th></th>
                                   <th>Sipariş No</th>
                                   <th>Müşteri Ad Soyad(Ünvan)</th>
                                   <th>Sipariş Tutarı(Kdv Dahil)</th>
                               </tr>
                           </thead>
                           <tbody class="searchable">`;
                        $.each(response.data, function (i) {
                            var price = 0;
                            if (response.data[i].orderDetails.length > 0) {
                                $.each(response.data[i].orderDetails, function (x) {
                                    /*                                prod += response.data[i].orderDetails[x].productSkus.title + ' x ' + response.data[i].orderDetails[x].quantity + "<br>";*/
                                    price += response.data[i].orderDetails[x].lineNetPrice;
                                });
                            }
                            const div = document.createElement('div');
                            str += `<tr>
                    <td>
                        <button type="button" onclick="chooseReturnOrder(${response.data[i].id})"  class="btn btn-success btn-sm main-color-text " style="color:white" data-id="${response.data[i].id}">
                           SEÇ
                        </button>
                    </td>
                    <td>${response.data[i].id}</td>
                    <td>${response.data[i].customer.name + ' ' + response.data[i].customer.surname + '( ' + response.data[i].customer.title + ' )'}</td>
                    <td>${price}</td>
                </tr>`;

                        });
                        str += `</tbody></table>`;
                        div.innerHTML = str;
                        document.getElementById('listSeachOrder').appendChild(div);
                        document.getElementById('firststep').style.display = "block";
                    }
                    else {

                        document.getElementById('firststep').style.display = "none";
                    }
                }
            });
      
        } else {
            return false;
        }
    }
    catch {
       
    }
    finally {
        LoaderSet('none');
    }
    
}

function chooseReturnOrder(id) {
    try {
        LoaderSet('block');
        document.getElementById('listOrderDetail').innerHTML = "";
        $.ajax({
            url: '/Home/GetOrderDetail/',
            type: 'GET',
            dataType: 'json',
            data: { 'OrderId': id },
            success: function (response) {
                if (response.data.length > 0) {
                    const div = document.createElement('div');
                    var str = "";
                    str = `<table id="retOrderTbl" class="table table-striped" style="width:100%">
                          <thead>
                            <tr>
                              <th scope="col" style="padding-left: 25px;">Seç</th>
                              <th scope="col" style="padding-left: 25px;">Ürün Adı</th>
                              <th scope="col" style="padding-left: 25px;">Birim Fiyat</th>
                              <th scope="col" style="padding-left: 25px;">İade Miktarı</th>    
                              <th scope="col" style="padding-left: 25px;">İade Nedeni</th>
                            </tr>
                          </thead>
                          <tbody>`;
                    $.each(response.data, function (i) {
                        str += `
                    <tr>
                        <td> <input id="ordChk${response.data[i].id}" style="width:50px;background-color:darkorchid;" class="form-check-input" type="checkbox" value="${response.data[i].OrderId}" data-prodsku="${response.data[i].productSkus.id}" data-orderid="${response.data[i].orderId}"  data-detailid="${response.data[i].id}" ></td>
                        <td> <input id="ordStockName${response.data[i].id}" style="width:90%;height:35px;font-size:12px;margin-left:20px" type="text"  class="form-control" value="${response.data[i].productSkus.title}" disabled></td>
                        <td> <input id="ordPrice${response.data[i].id}" style="width:90%;height:35px;font-size:12px;margin-left:20px"  class="form-control"  value="${response.data[i].unitPrice}" disabled></td>
                        <td> <input id="ordQuantity${response.data[i].id}" onchange="returnOrderQuantityCheck(this)" style="width:90%;height:35px;font-size:12px;margin-left:20px" type="number"  class="form-control" data-oldvalue="${response.data[i].quantity}" min="0" value="${response.data[i].quantity}"></div></td>
                        <td> <select id="returnType${response.data[i].id}" class="form-control" style="width:90%;height:35px;font-size:12px;margin-left:20px" >
                                        <option disabled value="none" selected> -- Seçiniz -- </option>
                                        <option value="kusur">Ürün Kusurlu</option>
                                        <option value="hata">Üretim Hatası</option>
                                        <option value="uyumsuz">Uyumsuz</option>
                                    </select>
                        </td>
                    </tr>
                        `;
                    })
                    str += `  </tbody>
                    </table>`;
                    div.innerHTML = str;
                    document.getElementById('listOrderDetail').appendChild(div);
                    document.getElementById('orderdetailtitle').innerHTML = response.data[0].orderId + ' Numaralı ';
                  
                    nextpagereturnorder(document.getElementById('firststep'));
                }

            },
            error: function (response) {
                SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
            }
        });
       
    }
    catch {
      
    }
    finally {
        LoaderSet('none');
    }
    
}
///RETURNORDER END
window.onclick = function (event) {
    if (event.target == document.getElementById("myModal")) {
        closemodal();
    }
}
function returnOrderQuantityCheck(e) {
    if (e.value > e.getAttribute("data-oldvalue")) {
        SetNotify('error', 'Hata', "Miktar önceki miktardan büyük olamaz!", 3000);
        e.value = e.getAttribute("data-oldvalue");
        return false;
    }
    else if (e.value <= 0) {
        SetNotify('error', 'Hata', "Miktar 0(sıfır) olamaz!", 3000);
        e.value = 1;
        return false;
    }
    else {
        return true;
    }

}

function returnordercheck(e) {
   
    try {
        LoaderSet('block');
        returnOrderDTO = [];
        var table = document.querySelector("#retOrderTbl"); //document.getElementById("retOrderTbl");
        var object = "";
        if (table != null)
        {
            for (var i = 1, row; row = table.rows[i]; i++) {
                var elems = row.cells[0].innerHTML;
                var first = elems.indexOf('"', 0)
                var second = elems.indexOf('"', first + 1)
                 object = elems.substring(first + 1, second);
                var orderId = document.getElementById(object).getAttribute('data-orderid');
                var productSkuId = document.getElementById(object).getAttribute('data-prodsku');
                var orderDetailId = document.getElementById(object).getAttribute('data-detailid');
                if (document.getElementById(object).checked == true) {

                    first = row.cells[3].innerHTML.indexOf('"', 0)
                    object = row.cells[3].innerHTML.substring(first + 1, row.cells[3].innerHTML.indexOf('"', first + 1));
                    var quantity = document.getElementById(object).value;
                    first = row.cells[4].innerHTML.indexOf('"', 0)
                    object = row.cells[4].innerHTML.substring(first + 1, row.cells[4].innerHTML.indexOf('"', first + 1));
                    var returnType = document.getElementById(object).value;
                    if (returnType != 'none') {
                        returnOrderDTO.push({
                            'Quantity': quantity,
                            'ReturnType': returnType,
                            'OrderId': orderId,
                            'ProductSkusId': productSkuId,
                            'OrderDetailId': orderDetailId
                        });
                    }
                    else {
                        returnOrderDTO = [];
                        throw "İade nedeni seçilmedi!";
                    }
                    //    for (var j = 1; col = row.cells[j]; j++) {
                    //         elems = row.cells[j].innerHTML;
                    //         first = elems.indexOf('"', 0)
                    //         second = elems.indexOf('"', first + 1)
                    //         object = elems.substring(first + 1, second);
                    //       
                    //}
                }
                
            }
            if (returnOrderDTO.length > 0) {
                $.ajax({
                    url: '/Home/AddReturnOrderTemp/',
                    type: 'POST',
                    dataType: 'json',
                    data: {
                        'json': JSON.stringify(returnOrderDTO)
                    },
                    success: function (response) {
                        SetNotify('success', 'Bilgi', response, 3000);
                        console.log(response);
                        document.getElementById('returnordertotal').innerHTML = response.data.item1 + ' TL ';
                        total = response.data.item1;
                        document.getElementById('myProgress').setAttribute("max", response.data.item1);
                        document.getElementById('cashReturn').setAttribute("data-id", response.data.item2);
                        document.getElementById('cardReturn').setAttribute("data-id", response.data.item2);
                        document.getElementById('openReturn').setAttribute("data-id", response.data.item2);
                        document.getElementById('piecedpayment').setAttribute("data-id", response.data.item2); 
                        document.getElementById('piecedpayment').setAttribute("data-type", 'return'); 
                        document.getElementById('piecedpayment').setAttribute("value", response.data.item1); 

                    },
                    error: function (response) {
                        SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
                    }
                });
               
                nextpagereturnorder(e);
            }
           
        }
        else
        {
            throw "Sipariş detayı olmadan ilerlenemez!";
        } 
    } catch (e) {
        SetNotify('error', 'Hata', e, 5000);
    }
    finally {
        LoaderSet('none');
    }
   

}

$("#firststep").click(function () {
    nextpagereturnorder(this);
})
$("#laststep").click(function () {
    nextpagereturnorder(this);
})

function nextpagereturnorder(e) {
    current_fs =  $(e).parent();
    next_fs = $(e).parent().next();
    $("#progressbar li").eq($("fieldset").index(next_fs)).addClass("active");
    next_fs.show();
    current_fs.animate({ opacity: 0 }, {
        step: function (now) {
            opacity = 1 - now;

            current_fs.css({
                'display': 'none',
                'position': 'relative'
            });
            next_fs.css({ 'opacity': opacity });
        },
        duration: 500
    });
    setProgressBar(++current);
}



$(".previous").click(function () {

    current_fs = $(this).parent();
    previous_fs = $(this).parent().prev();

    //Remove class active
    $("#progressbar li").eq($("fieldset").index(current_fs)).removeClass("active");

    //show the previous fieldset
    previous_fs.show();

    //hide the current fieldset with style
    current_fs.animate({ opacity: 0 }, {
        step: function (now) {
            // for making fielset appear animation
            opacity = 1 - now;

            current_fs.css({
                'display': 'none',
                'position': 'relative'
            });
            previous_fs.css({ 'opacity': opacity });
        },
        duration: 500
    });
    setProgressBar(--current);
});

function setProgressBar(curStep) {
    var percent = parseFloat(100 / steps) * curStep;
    percent = percent.toFixed();
    $(".progress-bar")
        .css("width", percent + "%")
}
function SetNotify(Itheme, Ititle, Imessage, Itime) {
     //theme = success,info,warning,error,none
    window.createNotification({
        closeOnClick: true,
        displayCloseButton: true,
        positionClass: 'nfc-top-right',
        showDuration: Itime,
        theme: Itheme
    })({
        title: Ititle,
        message: Imessage
    });
}

function LoaderSet(e) {
        document.getElementById("globalload").style.display = e;    
}


$("#paymentAdd").click(function () {


    let paymentOran = document.getElementById("paymentOran").value;
    let cmbOdeme = document.getElementById("paymentType").value;




    if (paymentOran == '' || paymentOran == undefined || paymentOran == null) {
        return alert('Oran alanı boş bırakılamaz.');
    }
    if (cmbOdeme == '' || cmbOdeme == undefined || cmbOdeme == null) {
        return alert('Ödeme alanı boş bırakılamaz.');
    }

    $("#paymentEmpty").css('display', 'none')
    oranResult += Number(paymentOran);


    if (oranResult <= total) {

        $(".oranSpanPr").css("width", oranResult);
        $(".oranSpan").text(oranResult);
        document.getElementById("myProgress").value = oranResult.toString().replace(",", ".");
        let html = `<tr id="append-tr${lineNum}">
                                <td class="coin_icon mt-2 p-1" >
                                    <span class=" my-auto paymentOranSpan"><b>${paymentOran}</b></span>
                                </td>
                                <td class="p-1">${cmbOdeme}</td>
                                <td class="pr-0 paymentClose" ><button type="button" onclick="paymentDeleteItem(${lineNum},${paymentOran})" class="btn btn-danger float-right pt-1 pb-1" style="min-height:25px"><i class="fa fa-times" style="cursor:pointer"></i></button></td>
                            </tr>`;
        lineNum++;
        $('#paymentTBody').append(html);

        if (oranResult == total) {
            document.getElementById("paymentSave").style.display = "block";
        }

    } else {
        alert('Limiti aştınız.Ekleme yapamazsınız.');
        return oranResult = oranResult - Number(paymentOran);
    }

});

function paymentDeleteItem(lineNum, paymentOran) {
    let line = $("#paymentTBody").find("#append-tr" + lineNum);

    if (line.length > 0) {
        $("#append-tr" + lineNum).remove();
        oranResult -= Number(paymentOran);
        $(".oranSpanPr").css("width", oranResult);
        $(".oranSpan").text(oranResult);
        document.getElementById("myProgress").value = oranResult.toString().replace(",", ".");
        if (oranResult == total) {
            document.getElementById("paymentSave").style.display = "block";
        }
        else {
            document.getElementById("paymentSave").style.display = "none";
        }
    }

}

$("#paymentSave").click(function () {
    let table = $("#paymentTBody");
    let json = []
    let url = "";
    table.find('tr').each(function (i, el) {
        let $tds = $(this).find('td'),
            tutar = $tds.eq(0).text().trim();
        type = $tds.eq(1).text().trim();

        json.push({ "Price": tutar, "Type": type })
    });
    if (document.getElementById("piecedpayment").getAttribute('data-type') == "return")
        url = '/Home/ReturnPiecedPayout/';
    else
        url = '/Home/PiecedPayout/';
    $.ajax({
        url: url,
        type: 'POST',
        dataType: 'json',
        data: {
            'id': document.getElementById("piecedpayment").getAttribute('data-id'),
            'json': JSON.stringify(json)
        },
        success: function (response) {
            SetNotify('success', 'Bilgi', response, 5000);
            if (document.getElementById("piecedpayment").getAttribute('data-type') == "return") {
                document.getElementById("laststep").click();
            }
            else {
                closemodal();
                getMiniCart();
            }
           
        },
        error: function (response) {
            SetNotify('error', 'Hata', JSON.parse(response.responseText).responseText, 3000);
        }
    });


});


$("#piecedpayment").click(function () {
    var baskettotal = document.getElementById("totalprice").value;
    var returntotal = document.getElementById("piecedpayment").value;
    baskettotal = baskettotal == '' ? 0 : baskettotal.replace(',','.');
    returntotal = returntotal == '' ? 0 : returntotal.replace(',', '.');
    console.log(baskettotal);
    console.log(returntotal);
    if (baskettotal > 0 || returntotal>0 ) {
        if (document.getElementById("OdemeSekli").style.display == "block") {
            document.getElementById("OdemeSekli").style.display = "none";
            total = 0.0;
        }
        else {
            document.getElementById("OdemeSekli").style.display = "block";
            total = returntotal > 0 ? returntotal : baskettotal;
        }
    }
    else {

        SetNotify('warning', 'Hata', "Tutar 0'dan' büyük olmalıdır.", 5000);
    }


});