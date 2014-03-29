package capaPresentacion;
import javax.swing.ComboBoxModel;
import javax.swing.DefaultComboBoxModel;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextArea;
import javax.swing.JTextField;

import javax.swing.WindowConstants;
import javax.swing.SwingUtilities;

import capaLogica.Gestor;
import capaLogica.Propiedad;
import capaLogica.TipoPropiedad;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

/**
* This code was edited or generated using CloudGarden's Jigloo
* SWT/Swing GUI Builder, which is free for non-commercial
* use. If Jigloo is being used commercially (ie, by a corporation,
* company or business for any purpose whatever) then you
* should purchase a license for each developer using Jigloo.
* Please visit www.cloudgarden.com for details.
* Use of Jigloo implies acceptance of these licensing terms.
* A COMMERCIAL LICENSE HAS NOT BEEN PURCHASED FOR
* THIS MACHINE, SO JIGLOO OR THIS CODE CANNOT BE USED
* LEGALLY FOR ANY CORPORATE OR COMMERCIAL PURPOSE.
*/
public class PantallaModificarPropiedad extends javax.swing.JFrame {
	Gestor gestor;
	private JTextField txtBusqueda;
	private JLabel direc;
	private JTextArea txtDireccion;
	private JLabel nomPro;
	private JTextField txtNumPropiedad;
	private JLabel numPro;
	private JComboBox cbxTipPropiedad;
	private JLabel ti;
	private JButton btnRegresar;
	private JButton btnModificar;
	private JComboBox cbxEstado;
	private JLabel estado;
	private JLabel tel;
	private JTextField txtTelefono;
	private JTextField txtNomPropietario;
	private JLabel area;
	private JTextField txtArea;
	private JLabel ubicacion;
	private JTextField txtUbicacion;
	private JLabel numComunidad;
	private JTextField txtNumComunidad;
	private JButton btnBuscar;
	
	/**
	* Auto-generated main method to display this JFrame
	*/
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				PantallaModificarPropiedad inst = new PantallaModificarPropiedad();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaModificarPropiedad() {
		super();
		initGUI();
		gestor= new Gestor();
		cargarDatosTiposPropiedades();
		
	}
	
	/*private void cargarNumPropiedades() {
		String[] datosPropiedades=gestor.obtenerTodasLasPropiedades();
		for(int i=0; i<datosPropiedades.length;i++){

			System.out.println(datosPropiedades[i]);
			cbxNumPropiedad.addItem(datosPropiedades[i]);		
		}	
	}*/
	private void cargarDatosTiposPropiedades() {
		String [] listaTiposPropiedades = gestor.obtenerTodasLosTipos();
		for(int i=0; i<listaTiposPropiedades.length;i++){
			cbxTipPropiedad.addItem(listaTiposPropiedades[i]);		
		}
	}

	private void initGUI() {
		try {
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			getContentPane().setBackground(new java.awt.Color(0,128,255));
			this.setIconImage(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/abo.jpg")).getImage());
			this.setTitle("Modificar Propiedad");
			getContentPane().setLayout(null);
			{
				txtBusqueda = new JTextField();
				getContentPane().add(txtBusqueda);
				txtBusqueda.setBounds(17, 29, 207, 23);
			}
			{
				btnBuscar = new JButton();
				getContentPane().add(btnBuscar);
				btnBuscar.setText("Buscar");
				btnBuscar.setBounds(248, 21, 127, 40);
				btnBuscar.setBackground(new java.awt.Color(255,255,255));
				btnBuscar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/bus1.gif")));
				btnBuscar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnBuscar.actionPerformed, event="+evt);
						//TODO add your code for btnBuscar.actionPerformed
						btnBuscar_actionPerformed(evt);
					}

				});
			}
			{
				txtNumComunidad = new JTextField();
				getContentPane().add(txtNumComunidad);
				txtNumComunidad.setBounds(171, 150, 204, 23);
			}
			{
				numComunidad = new JLabel();
				getContentPane().add(numComunidad);
				numComunidad.setText("Numero Comunidad");
				numComunidad.setBounds(19, 151, 145, 20);
			}
			{
				txtUbicacion = new JTextField();
				getContentPane().add(txtUbicacion);
				txtUbicacion.setBounds(171, 107, 204, 23);
			}
			{
				ubicacion = new JLabel();
				getContentPane().add(ubicacion);
				ubicacion.setText("Ubicacion");
				ubicacion.setBounds(19, 108, 142, 20);
			}
			{
				txtArea = new JTextField();
				getContentPane().add(txtArea);
				txtArea.setBounds(171, 72, 204, 23);
			}
			{
				area = new JLabel();
				getContentPane().add(area);
				area.setText("Area");
				area.setBounds(17, 73, 144, 20);
			}
			{
				txtNomPropietario = new JTextField();
				getContentPane().add(txtNomPropietario);
				txtNomPropietario.setBounds(171, 190, 204, 23);
			}
			{
				nomPro = new JLabel();
				getContentPane().add(nomPro);
				nomPro.setText("Nombre Propietario");
				nomPro.setBounds(19, 190, 152, 23);
			}
			{
				txtDireccion = new JTextArea();
				getContentPane().add(txtDireccion);
				txtDireccion.setBounds(171, 231, 204, 56);
			}
			{
				direc = new JLabel();
				getContentPane().add(direc);
				direc.setText("Direccion");
				direc.setBounds(19, 244, 152, 30);
			}
			{
				txtTelefono = new JTextField();
				getContentPane().add(txtTelefono);
				txtTelefono.setBounds(171, 308, 204, 23);
			}
			{
				tel = new JLabel();
				getContentPane().add(tel);
				tel.setText("Telefono");
				tel.setBounds(19, 308, 152, 23);
			}
			{
				estado = new JLabel();
				getContentPane().add(estado);
				estado.setText("Estado");
				estado.setBounds(19, 347, 152, 19);
			}
			{
				ComboBoxModel cbxEstadoModel = 
					new DefaultComboBoxModel(
							new String[] { "Habitada", "Desocupada" });
				cbxEstado = new JComboBox();
				getContentPane().add(cbxEstado);
				cbxEstado.setModel(cbxEstadoModel);
				cbxEstado.setBounds(171, 345, 204, 26);
				cbxEstado.setBackground(new java.awt.Color(255,255,255));
			}
			{
				ti = new JLabel();
				getContentPane().add(ti);
				ti.setText("Tipo Propiedad");
				ti.setBounds(19, 387, 152, 23);
			}
			{
				btnModificar = new JButton();
				getContentPane().add(btnModificar);
				btnModificar.setText("Modificar");
				btnModificar.setBounds(19, 466, 142, 44);
				btnModificar.setBackground(new java.awt.Color(255,255,255));
				btnModificar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/modificar.gif")));
				btnModificar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnModificar.actionPerformed, event="+evt);
						//TODO add your code for btnModificar.actionPerformed
						btnModificar_actionPerformed(evt);
					}

				});
			}
			{
				btnRegresar = new JButton();
				getContentPane().add(btnRegresar);
				btnRegresar.setText("Regresar");
				btnRegresar.setBounds(242, 466, 127, 44);
				btnRegresar.setBackground(new java.awt.Color(255,255,255));
				btnRegresar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/salir.gif")));
				btnRegresar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnRegresar.actionPerformed, event="+evt);
						//TODO add your code for btnRegresar.actionPerformed
						btnRegresar_actionPerformed(evt);
					}

				});
			}
			{
				ComboBoxModel cbxTipPropiedadModel = 
					new DefaultComboBoxModel(
							new String[] { });
				cbxTipPropiedad = new JComboBox();
				getContentPane().add(cbxTipPropiedad);
				cbxTipPropiedad.setModel(cbxTipPropiedadModel);
				cbxTipPropiedad.setBounds(171, 387, 204, 23);
				cbxTipPropiedad.setBackground(new java.awt.Color(255,255,255));
			}
			{
				numPro = new JLabel();
				getContentPane().add(numPro);
				numPro.setText("Numero Propiedad");
				numPro.setBounds(19, 422, 152, 18);
			}
			{
				txtNumPropiedad = new JTextField();
				getContentPane().add(txtNumPropiedad);
				txtNumPropiedad.setEditable(false);
				txtNumPropiedad.setBounds(171, 420, 204, 23);
			}
			pack();
			this.setSize(418, 576);
		} catch (Exception e) {
		    //add your error handling code here
			e.printStackTrace();
		}
	}
	

	private void btnBuscar_actionPerformed(ActionEvent evt) {
		String numPropiedad;
		Propiedad propiedad;
		try {
			numPropiedad=txtBusqueda.getText();
			propiedad=gestor.buscarPropiedad(numPropiedad);
			txtArea.setText(propiedad.getAreaPropiedad()+"");
			txtUbicacion.setText(propiedad.getUbicaPropiedad()+"");
			txtNumComunidad.setText(propiedad.getNumComunidad()+"");
			txtNomPropietario.setText(propiedad.getNomPropietario()+"");
			txtDireccion.setText(propiedad.getDireccionPropietario()+"");
			txtTelefono.setText(propiedad.getTelefonoPropietario()+"");
			txtNumPropiedad.setText(propiedad.getNumPropiedad()+"");
			//cbxEstado.addItem(propiedad.getEstadoPropiedad());
			//txtTipoPropiedad.setText(propiedad.getIdTipoPropiedad()+"");
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	}
	
	private void btnRegresar_actionPerformed(ActionEvent evt) {
		PantallaPrincipal PP=new PantallaPrincipal();
		PP.setVisible(true);
		PantallaModificarPropiedad.this.dispose();
	}
	
	private void btnModificar_actionPerformed(ActionEvent evt) {
		String numPropiedad, areaPropiedad, ubicaPropiedad,
		numComunidad, nomPropietario, direccionPropietario, 
		telefonoPropietario, estadoPropiedad,
		idTipoPropiedad, mjs;
		try {
			
			numPropiedad=txtNumPropiedad.getText();
			areaPropiedad=txtArea.getText();
			ubicaPropiedad=txtUbicacion.getText();
			numComunidad=txtNumComunidad.getText();
			nomPropietario=txtNomPropietario.getText();
			direccionPropietario=txtDireccion.getText();
			telefonoPropietario=txtTelefono.getText();
			estadoPropiedad= (String) cbxEstado.getSelectedItem();
			idTipoPropiedad= (String) cbxTipPropiedad.getSelectedItem();
			TipoPropiedad tipoPropiedad=gestor.buscarTipoPropiedad(idTipoPropiedad);
			idTipoPropiedad=tipoPropiedad.getIdTipoPropiedad();
			mjs=gestor.modificarPropiedad(numPropiedad, areaPropiedad, ubicaPropiedad, 
		    numComunidad, nomPropietario, direccionPropietario, telefonoPropietario,
		    estadoPropiedad, idTipoPropiedad);
			JOptionPane.showMessageDialog(this,mjs,"Mensaje",JOptionPane.INFORMATION_MESSAGE);
		} catch (Exception e) {
			
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		
		
		
	}

}
