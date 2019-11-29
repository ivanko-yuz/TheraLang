import { async, TestBed } from '@angular/core/testing';
import { ResourcesInternalTableComponent } from './resources-internal-table.component';
describe('ResourcesInternalTableComponent', () => {
    let component;
    let fixture;
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ResourcesInternalTableComponent]
        })
            .compileComponents();
    }));
    beforeEach(() => {
        fixture = TestBed.createComponent(ResourcesInternalTableComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
//# sourceMappingURL=resources-internal-table.component.spec.js.map