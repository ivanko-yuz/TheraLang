import { Injectable } from "@angular/core";
import { HttpClient} from "@angular/common/http";
import { MemberFee } from "src/app/shared/models/member-fee/member-fee";
import { memberFeeUrl } from "src/app/configs/api-endpoint.constants";

@Injectable()
export class MemberFeeService {
    constructor(private http: HttpClient) {
    }

    getMemberFees() {
        return this.http.get(memberFeeUrl);
    }

    createMemberFee(memberFee: MemberFee) {
        return this.http.post(memberFeeUrl, memberFee);
    }

    deleteMemberFee(id: number) {
        return this.http.delete(memberFeeUrl + "/" + id);
    }
}
