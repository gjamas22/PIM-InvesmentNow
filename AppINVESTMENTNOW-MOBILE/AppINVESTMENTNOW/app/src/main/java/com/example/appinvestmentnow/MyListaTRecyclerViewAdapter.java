package com.example.appinvestmentnow;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.appcompat.widget.AppCompatTextView;
import androidx.recyclerview.widget.RecyclerView;

import java.util.List;

/**
 * {@link RecyclerView.Adapter} that can display a {@link Transacao}.
 * TODO: Replace the implementation with code for your data type.
 */
public class MyListaTRecyclerViewAdapter extends RecyclerView.Adapter<MyListaTRecyclerViewAdapter.ViewHolder> {

    private final List<Transacao> mValues;

    public MyListaTRecyclerViewAdapter(List<Transacao> trans) {
        mValues = trans;
    }

    @Override
    public ViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext())
                .inflate(R.layout.fragment_lista_t, parent, false);
        return new ViewHolder(view);
    }

    @Override
    public void onBindViewHolder(final ViewHolder holder, int position) {
        holder.mItem = mValues.get(position);
        holder.mIdView.setText(String.valueOf(mValues.get(position).getCodTransacao()));
        holder.mValorView.setText(String.valueOf(mValues.get(position).getValor_investido()));
        holder.mQTDView.setText(String.valueOf(mValues.get(position).getQuantidade_moedas()));
        holder.mCarteiraView.setText(String.valueOf(mValues.get(position).getCodCarteira()));
        holder.mMoedaView.setText(String.valueOf(mValues.get(position).getCodMoeda()));
        holder.mTarifaView.setText(String.valueOf(mValues.get(position).getCodTarifa()));
        holder.mCodCliente.setText(String.valueOf(mValues.get(position).getCodCliente()));


    }

    @Override
    public int getItemCount() {
        return mValues.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder {
        public final View mView;
        public final AppCompatTextView mIdView;
        public final AppCompatTextView mValorView;
        public final AppCompatTextView mQTDView;
        public final AppCompatTextView mCarteiraView;
        public final AppCompatTextView mMoedaView;
        public final AppCompatTextView mTarifaView;
        public final AppCompatTextView mCodCliente;

        public Transacao mItem;

        public ViewHolder(View view) {
            super(view);
            mView = view;
            mIdView = (AppCompatTextView) view.findViewById(R.id.txtID);
            mValorView = (AppCompatTextView) view.findViewById(R.id.txtValor);
            mQTDView = (AppCompatTextView) view.findViewById(R.id.txtQTD);
            mCarteiraView = (AppCompatTextView) view.findViewById(R.id.txtCarteira);
            mMoedaView = (AppCompatTextView) view.findViewById(R.id.txtMoeda);
            mTarifaView = (AppCompatTextView) view.findViewById(R.id.txtTarifa);
            mCodCliente = (AppCompatTextView) view.findViewById(R.id.txtCodUsuario);



        }

        @Override
        public String toString() {
            return super.toString() + "'" + mValorView.getText() + "'";
        }
    }
}