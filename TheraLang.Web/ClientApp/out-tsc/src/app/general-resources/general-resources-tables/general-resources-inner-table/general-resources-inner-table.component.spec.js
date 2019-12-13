import { async, TestBed } from '@angular/core/testing';
import { GeneralResourcesInnerTableComponent } from './general-resources-inner-table.component';
describe('GeneralResourcesInnerTableComponent', () => {
    let component;
    let fixture;
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [GeneralResourcesInnerTableComponent]
        })
            .compileComponents();
    }));
    beforeEach(() => {
        fixture = TestBed.createComponent(GeneralResourcesInnerTableComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
//# sourceMappingURL=general-resources-inner-table.component.spec.js.map