import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Global } from '../model/global';

@Component({
  selector: 'app-show-product-category',
  templateUrl: './show-product-category.component.html',
  styleUrls: ['./show-product-category.component.scss'],
})
export class ShowProductCategoryComponent implements OnInit {
  itemType: any[] = [];
  itemCategory: any[] = [];
  // tslint:disable-next-line:variable-name
  constructor(private http: HttpClient) {
    // this.ngOnInit();
  }

  ngOnInit() {
    debugger;
    this.productCategoryList();
    this.itemType.push('Test 1', 'Test 2', 'Test 3');
  }

  productCategoryList() {
    const urlString = Global.APIURL + 'api/UserLevel/GetItemCategory';
    const urlSearchParams = new URLSearchParams();
    urlSearchParams.append('compId', '7AF0D3AA-698E-44B4-8042-68EE81C8EABA');
    this.http.get(urlString).subscribe(
      res => {
        console.log(res);
      }
    );
  }

  openItemType(btnValue) {
    alert(btnValue);
  }
}
